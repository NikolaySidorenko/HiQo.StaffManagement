using System.Web.Mvc;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class GradeController : Controller
    {
        private IGradeService _service;

        public GradeController(IGradeService service)
        {
            _service = service;
        }

        // GET: Grade
        public ActionResult Index()
        {
            var grades = _service.GetAll();
            return View(grades);
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