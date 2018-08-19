using System.Collections.Generic;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using FluentValidation;
using HiQo.StaffManagement.Domain.Service.Interfaces;
using HiQo.StaffManagement.Web.Core.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace HiQo.StaffManagement.Web.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly IValidatorFactory _factory;
        private readonly IUpsertUserService _upsertService;
        //private readonly IAuthService _authService;

        public AccountController(IValidatorFactory factory,IUpsertUserService userService)//,IAuthService authService)
        {
            _upsertService = userService;
            _factory = factory;
            //_authService = authService;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel registerUser)
        {
            var validator = _factory.GetValidator<RegisterViewModel>();
            var result = validator.Validate(registerUser);
            if (result.IsValid)
            {
                var user = Mapper.Map<UpsertUser>(registerUser);
                user.UserId = _upsertService.GetLastId() + 1;
                return RedirectToAction("Create", "User", user);
            }
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }


        [HttpPost]
        public ActionResult LogIn(LogInViewModel model)
        {
            var user = _upsertService.GetToLogIn(model.Email, model.Password);
            if (user != null)
            {
                var authContext = Request.GetOwinContext();
                var authManager = authContext.Authentication;

                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Email, model.Email));
                claims.Add(new Claim(ClaimTypes.Name, user.UserName));
                claims.Add(new Claim(ClaimTypes.Role, user.Role.Name));

                var identityClaim = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);

                authManager.SignIn(new AuthenticationProperties { IsPersistent = false }, identityClaim);
                return RedirectToAction("Index", "User");
            }

            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "User");
        }


    }
}