using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystem.Gateway;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Manager
{
    public class CourseManager
    {
        CourseGateway courseGateway=new CourseGateway();
        public List<Semister> GetAllSemister()
        {
            return courseGateway.GetAllSemister();
        }
    }
}