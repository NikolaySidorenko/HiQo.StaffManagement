using System.Web;
using System.Web.Mvc;
using AutoMapper;
using FluentValidation;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Service.Interfaces;
using HiQo.StaffManagement.Web.Core.Auth.Interfaces;
using HiQo.StaffManagement.Web.Core.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace HiQo.StaffManagement.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IValidatorFactory _factory;
        private readonly IUpsertUserService _upsertService;
        private readonly IAuthService _authService;

        public IAuthenticationManager AuthenticationManager
        {
            get { return HttpContext.GetOwinContext().Authentication; }
            private set { }
        }

        public AccountController(IValidatorFactory factory,IUpsertUserService userService,IAuthService authService)
        {
            _upsertService = userService;
            _factory = factory;
            _authService = authService;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel registerUser)
        { 
            var validator = _factory.GetValidator<RegisterViewModel>();
            var result = validator.Validate(registerUser);
            if (result.IsValid)
            {
                var user = Mapper.Map<UserDto>(registerUser);
                user.Id = _upsertService.GetLastId() + 1;
                user.DepartmentId = 1;
                user.CategoryId = 1;
                user.PositionId = 1;
                user.GradeId = 1;
                user.RoleId = 3;
                _authService.RegisterUser(user);
            }
            return View();
        }

        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LogInViewModel model)
        {
            var validtor = _factory.GetValidator<LogInViewModel>();
            var result = validtor.Validate(model);
            if (result.IsValid)
            {
                if (User.Identity.IsAuthenticated)
                {
                    AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                }

                var user = _authService.IsUserExists(model);
                if (user != null)
                {
                    var identityClaim =
                        _authService.CreateLoginIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                    AuthenticationManager.SignIn(new AuthenticationProperties {IsPersistent = false}, identityClaim);
                    return RedirectToAction("Index", "User");
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "User");
        }


    }
}