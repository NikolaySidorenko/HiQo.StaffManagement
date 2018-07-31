using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Service;
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
            var info = _upsertService.GetSharedInfo();
            SelectList departmentList=new SelectList(info.Departments,"DepartmentId","Name");
            SelectList categoriesList=new SelectList(info.Categories,"CategoryId","Name");
            SelectList positionList = new SelectList(info.Positions, "PositionId", "Name");
            SelectList gradeList = new SelectList(Mapper.Map<IEnumerable<GradeViewModel>>(info.Grades), "GradeId", "FullName");
            SelectList roleList = new SelectList(info.Roles, "RoleId", "Name");

            ViewBag.Roles = roleList;
            ViewBag.Categories = categoriesList;
            ViewBag.Positions = positionList;
            ViewBag.Grades = gradeList;
            ViewBag.Departments = departmentList;
            var user = Mapper.Map<CreateEditUser>(upsertUser);
            return View("UpsertProfile",user);
        }

        public ActionResult Create()
        {
            var info = _upsertService.GetSharedInfo();
            SelectList departmentList = new SelectList(info.Departments, "DepartmentId", "Name");
            SelectList categoriesList = new SelectList(info.Categories, "CategoryId", "Name");
            SelectList positionList = new SelectList(info.Positions, "PositionId", "Name");
            SelectList gradeList = new SelectList(Mapper.Map<IEnumerable<GradeViewModel>>(info.Grades), "GradeId", "FullName");
            SelectList roleList=new SelectList(info.Roles,"RoleId","Name");

            ViewBag.Categories = categoriesList;
            ViewBag.Positions = positionList;
            ViewBag.Grades = gradeList;
            ViewBag.Departments = departmentList;
            ViewBag.Roles = roleList;
            return View("UpsertProfile",null);
        }


        [HttpPost]
        public ActionResult UpsertProfile(CreateEditUser user)
        {
            var us = Mapper.Map<UserDto>(user);

            if(us.UserId!=0)
                _upsertService.Update(us);
            else
                _upsertService.Create(us);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult PartialEditCategories(int id)
        {
            var categories = _upsertService.GetCategoriesByDepartmentId(id);
            return PartialView("PartialEditCategories",categories);
        }

    }
}