using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Service.Interfaces;
using HiQo.StaffManagement.Web.Core.Models;

namespace HiQo.StaffManagement.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUpsertUserService _upsertService;

        public UserController(IUpsertUserService upsertService)
        {
            _upsertService = upsertService;
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
        public ActionResult Update(int id)
        {
            var upsertUser = _upsertService.GetById(id);
            CreateSelectLists();
            var user = Mapper.Map<CreateEditUser>(upsertUser);
            return View("UpsertProfile",user);
        }

        public ActionResult Create()
        {
            CreateSelectLists();
            return View("UpsertProfile",null);
        }


        [HttpPost]
        public ActionResult UpsertProfile(CreateEditUser user)
        { 
            if (ModelState.IsValid)
            {
                var userDto = Mapper.Map<UserDto>(user);

                if (userDto.UserId != 0)
                    _upsertService.Update(userDto);
                else
                    _upsertService.Create(userDto);
            }
            else
            {
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