using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Manager;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentManager departmentManager = new DepartmentManager();
        CourseManager courseManager=new CourseManager();
        //
        // GET: /Department/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Department department)
        {
            //if (manager.IsExitedDepartment(department))
            //{
            //    ViewBag.Massege = manager.Save(department);
            //    return View();
            //}
          ViewBag.Massege=  departmentManager.Save(department);
            return View();
        }

        public ActionResult ShowAllDepartment()
        {
            List<Department> departments = departmentManager.GetAllDepartments();
            return View(departments);
        }

        public ActionResult AddCourse()
        {

            ViewBag.Departments = departmentManager.GetAllDepartments();
            ViewBag.Semisters = courseManager.GetAllSemister();
            return View();
        }

    }
}