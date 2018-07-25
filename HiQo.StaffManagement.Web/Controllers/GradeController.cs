using System.Web.Mvc;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Web.Controllers
{
    public class GradeController : Controller
    {
        private IGradeService _service;

        public GradeController(IGradeService gradeService)
        {
            _service = gradeService;
        }
        // GET: Grade
        public ActionResult Index()
        {
            var grades= _service.GetAll();
            return View(grades);
        }
    }
}