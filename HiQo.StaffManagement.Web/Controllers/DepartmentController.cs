using System.Web.Mvc;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartmentService _service;

        public DepartmentController(IDepartmentService service)
        {
            _service = service;
        }

        // GET: Department
        public ActionResult Index()
        {
            var departments = _service.GetAll();
            return View(departments);
        }
    }
}