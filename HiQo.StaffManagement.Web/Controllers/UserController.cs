using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using FluentValidation;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Service.Interfaces;
using HiQo.StaffManagement.Web.Core.Models;

namespace HiQo.StaffManagement.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUpsertUserService _upsertService;
        private readonly IValidatorFactory _factory;

        public UserController(IUpsertUserService upsertService,IValidatorFactory factory)
        {
            _upsertService = upsertService;
            _factory = factory;
        }

        // GET: User
        public ActionResult Index()
        {
            var users = _upsertService.GetAll();
            return View(users);
        }

        public ActionResult Profile(int id)
        {
            var user = _upsertService.GetById(id);
            return View(user);
        }

        [HttpGet]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id)
        {
            var upsertUser = _upsertService.GetById(id);
            CreateSelectLists();
            var user = Mapper.Map<UpsertUser>(upsertUser);
            return View("UpsertProfile",user);
        }

        [HttpGet]
        public ActionResult Create()
        {
            CreateSelectLists();
            var user = TempData["User"] as UpsertUser;
            TempData["User"] = null;
            return View("UpsertProfile",user);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _upsertService.DeleteById(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpsertProfile(UpsertUser user)
        {

            var validator = _factory.GetValidator<UpsertUser>();
            var result = validator.Validate(user);
            if (result.IsValid)
            {
                var userDto = Mapper.Map<UserDto>(user);

                if (userDto.Id != 0)
                    _upsertService.Update(userDto);
                else
                    _upsertService.Create(userDto);
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName,error.ErrorMessage);
                }
               
                CreateSelectLists();
                return View("UpsertProfile", user);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult PartialEditCategories(int id)
        {
            var categories = _upsertService.GetCategoriesByDepartmentId(id);
            return PartialView("PartialEditCategories",categories);
        }

        public void CreateSelectLists()
        {
            var info = _upsertService.GetSharedInfo();
            SelectList departmentList = new SelectList(info.Departments, "DepartmentId", "Name");
            SelectList categoriesList = new SelectList(info.Categories, "CategoryId", "Name");
            SelectList positionList = new SelectList(info.Positions, "PositionId", "Name");
            SelectList gradeList = new SelectList(Mapper.Map<IEnumerable<GradeViewModel>>(info.Grades), "GradeId", "FullName");
            SelectList roleList = new SelectList(info.Roles, "RoleId", "Name");

            ViewBag.Categories = categoriesList;
            ViewBag.Positions = positionList;
            ViewBag.Grades = gradeList;
            ViewBag.Departments = departmentList;
            ViewBag.Roles = roleList;
        }
    }
}