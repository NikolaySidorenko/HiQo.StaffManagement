using System.Web.Mvc;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Web.Controllers
{
    public class PositionController : Controller
    {
        private IPositionService _service;

        public PositionController(IPositionService positionService)
        {
            _service = positionService;
        }

        // GET: Position
        public ActionResult Index()
        {
            var positions = _service.GetAll();
            return View(positions);
        }
    }
}