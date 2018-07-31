using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Service.Interfaces;
using HiQo.StaffManagement.Web.Core.Models;

namespace HiQo.StaffManagement.Web.Areas.Admin.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartmentService _service;

        public DepartmentController(IDepartmentService departmentService)
        {
            _service = departmentService;
        }

        // GET: Department
        public ActionResult Index()
        {
            var departments = Mapper.Map<IEnumerable<DepartmentViewModel>>( _service.GetAll());
            return View(departments);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Upsert",null);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var department = Mapper.Map<DepartmentViewModel>(_service.GetById(id));
            return View("Upsert",department);
        }

        public ActionResult Upsert(DepartmentViewModel model)
        {
            var department = Mapper.Map<DepartmentDto>(model);
            _service.Upsert(department);
            return RedirectToAction("Index");
        }
    }
}