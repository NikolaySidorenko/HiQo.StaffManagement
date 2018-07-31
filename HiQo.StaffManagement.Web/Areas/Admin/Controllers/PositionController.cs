using System.Web.Mvc;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Web.Areas.Admin.Controllers
{
    public class PositionController : Controller
    {
        private IPositionService _service;

        public PositionController(IPositionService service)
        {
            _service = service;
        }

        // GET: Position
        public ActionResult Index()
        {
            var positins = _service.GetAll();
            return View(positins);
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