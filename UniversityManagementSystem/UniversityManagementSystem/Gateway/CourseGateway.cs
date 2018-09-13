using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Gateway
{
    public class CourseGateway : Gateway
    {
        public List<Semister> GetAllSemister()
        {

            Query = "select * from Semister_tb";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            List<Semister> semisters = new List<Semister>();

            while (reader.Read())
            {
                Semister semister = new Semister();
                semister.Name = reader["Semister"].ToString();
                semisters.Add(semister);
            }
            Connection.Close();
            return semisters;
        }
    }
}