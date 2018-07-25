using System.Web.Mvc;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Web.Controllers
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
            var catigories = _service.GetAll();
            return View(catigories);
        }
    }
}