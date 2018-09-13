using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Gateway
{
    public class DepartmentGateway : Gateway
    {
        public int Save(Department department)
        {
            Query = "Insert into Department_tb(Code,Name)values(@code,@name)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("code", department.Code);
            Command.Parameters.AddWithValue("name", department.Name);
            Connection.Open();
            int rowCount = Command.ExecuteNonQuery();
            Connection.Close();
            return rowCount;
        }
        public List<Department> GetAllDepartments()
        {

            Query = "select * from Department_tb";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            List<Department> departments = new List<Department>();

            while (reader.Read())
            {
                Department department=new Department();
                department.Id = (int) reader["id"];
                department.Code=(string) reader["code"];
                department.Name = (string) reader["name"];
                departments.Add(department);
            }
            Connection.Close();
            return departments;
        }

        public bool IsExitedDepartment(Department department)
        {
            Query = "Select * From Department_tb where name=@name";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("name", department.Name);           
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            
            Connection.Close();
            return false;
        } 
        public bool IsExitedCode(Department department)
        {
            Query = "Select * From Department_tb where name=@code";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("code", department.Code);           
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            
            Connection.Close();
            return false;
        }
    }
}