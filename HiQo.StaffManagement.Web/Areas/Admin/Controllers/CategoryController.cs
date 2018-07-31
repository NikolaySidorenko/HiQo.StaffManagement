using System.Web.Mvc;
using AutoMapper;
using HiQo.StaffManagement.Domain.Service.Interfaces;
using HiQo.StaffManagement.Web.Core.Models;

namespace HiQo.StaffManagement.Web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        // GET: Category
        public ActionResult Index()
        {
            var categories =_service.GetAll();
            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var info = _service.GetSharedInfo();
            SelectList departments = new SelectList(info.Departments, "DepartmentId", "Name");
            ViewBag.Departments = departments;
            return View("Upsert",null);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var category = Mapper.Map<CategoryViewModel>(_service.GetById(id));
            SelectList departments=new SelectList(category.SharedInfo.Departments,"DepartmentId","Name");
            ViewBag.Departments = departments;

            return View("Upsert");
        }

        public ActionResult Upsert()
        {
            return View("Index");
        }

    }
}