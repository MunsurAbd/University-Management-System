using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystem.Gateway;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Manager
{
    public class DepartmentManager
    {
        DepartmentGateway gateway=new DepartmentGateway();
        public string Save(Department department)
        {
            if (gateway.Save(department)>0)
            {
                return "Department is saved";
            }
            return "Department is not saved";
        }

        public List<Department> GetAllDepartments()
        {
            return gateway.GetAllDepartments();
        }

        public bool IsExitedDepartment(Department department)
        {
            if (gateway.IsExitedDepartment(department))
            {
                return true;
            }
            return false;
        }

        public string IsExitedCode(Department department)
        {
            if (gateway.IsExitedCode(department))
            {
                return "Insert Unique Department Code";
            }
            return " ";
        }
    }
}