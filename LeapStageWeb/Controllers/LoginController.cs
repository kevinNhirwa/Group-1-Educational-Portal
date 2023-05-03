using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using LeapStageWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeapStageWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login([Bind("email,password")] Parent parent)
        {

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LeapStageDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("selectParent", con))
                {
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@email", parent.email);
                        
                        cmd.Parameters.AddWithValue("@password", parent.password);
                        cmd.ExecuteNonQuery();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {


                        //List<Parent> parent = cmd.DataReader()

                    }
                }
            }

            return View("../Courses/Index");
        }


    }
}