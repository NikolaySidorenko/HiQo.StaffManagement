using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using HiQo.StaffManagement.Domain.Service.Interfaces;
using HiQo.StaffManagement.Web.Core.Models;

namespace HiQo.StaffManagement.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class CommonController : Controller
    {
        private readonly IPositionService _positionService;
        private readonly IDepartmentService _departmentService;
        private readonly ISharedService _sharedService;
        private Dictionary<string, string> _partialViewByUrl;
        

        public CommonController(IPositionService positionService,IDepartmentService departmentService, ISharedService sharedService)
        {
            _positionService = positionService;
            _sharedService = sharedService;
            _departmentService = departmentService;

            InitializePartialViewDictionary();
        }

        // GET: Admin/Common
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Positions()
        {
            var path = HttpContext.Request.Url.LocalPath;
            var viewName = GetPartialViewName(path);
            if (viewName == null)
            {
                return HttpNotFound(nameof(viewName));
            }

            var positions = _positionService.GetAll();
            ViewBag.Partial = viewName;
            ViewBag.Data = positions;

            return View("Index");
        }

        public ActionResult Position(int id)
        {
            var path = HttpContext.Request.Url.LocalPath;
            var viewName = GetPartialViewName(path);
            if (viewName == null)
            {
                return HttpNotFound(nameof(viewName));
            }

            var position = Mapper.Map<PositionViewModel>(_positionService.GetById(id));
            var info = _sharedService.GetSharedInfo();

            SelectList categories = new SelectList(info.Categories, "CategoryId", "Name");
            ViewBag.Partial = viewName;
            ViewBag.Data = position;
            ViewBag.Categories = categories;

            return View("Index");
        }

        public ActionResult PositionCreate()
        {
            ViewBag.Partial = "PartialPositionUpsert";
            var info = _sharedService.GetSharedInfo();

            SelectList categories = new SelectList(info.Categories, "CategoryId", "Name");

            ViewBag.Categories = categories;

            return View("Index");
        }


        private string GetPartialViewName(string path)
        {
            var paramsList = path.Split('/');
            var name = _partialViewByUrl[paramsList[3]];

            return name;
        }

        private void InitializePartialViewDictionary()
        {
            _partialViewByUrl = new Dictionary<string, string>();
            _partialViewByUrl.Add("Positions", "PartialPositionIndex");
            _partialViewByUrl.Add("Position", "PartialPositionUpsert");
            _partialViewByUrl.Add("Departments", "DepartmentsPartialView");
            _partialViewByUrl.Add("Department", "UpsertDepartmentPartialView");
        }
    }
}