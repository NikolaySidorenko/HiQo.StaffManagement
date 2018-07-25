using System.Web.Mvc;
using HiQo.StaffManagement.Domain.Service;

namespace HiQo.StaffManagement.Web.Controllers
{
    public class UserController : Controller
    {
        private IUserService _service;

        public UserController(IUserService userService)
        {
            _service = userService;
        }
        // GET: User
        public ActionResult Index()
        {
            var users = _service.GetAll();
            return View(users);
        }
    }
}