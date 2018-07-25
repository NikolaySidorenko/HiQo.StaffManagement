using System.Web.Mvc;
using HiQo.StaffManagement.Domain.Service;

namespace HiQo.StaffManagement.Web.Controllers
{
    public class RoleController : Controller
    {
        private IRoleSrivice _service;

        public RoleController(IRoleSrivice service)
        {
            _service= service;
        }

        public ActionResult Index()
        {
            var roles =_service.GetAll();
            return View(roles);
        }
    }
}