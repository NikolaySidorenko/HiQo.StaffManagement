using System.Web.Mvc;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Web.Areas.Admin.Controllers
{
    public class RoleController : Controller
    {
        private IRoleSerivice _serivice;

        public RoleController(IRoleSerivice serivice)
        {
            _serivice = serivice;
        }

        // GET: Role
        public ActionResult Index()
        {
            var roles = _serivice.GetAll();
            return View(roles);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Upsert");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            return View("Upsert");
        }

        public ActionResult Upsert()
        {
            return View("Index");
        }
    }
}