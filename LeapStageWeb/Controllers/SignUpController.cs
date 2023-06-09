﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using LeapStageWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeapStageWeb.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create([Bind("Id,fullName,email,phone,password")] Parent parent)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LeapStageDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("registerParent1", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@fullName", parent.fullName);
                    cmd.Parameters.AddWithValue("@email", parent.email);
                    cmd.Parameters.AddWithValue("@phone", parent.phone);
                    cmd.Parameters.AddWithValue("@password", parent.password);
                    cmd.Parameters.AddWithValue("@isParent", true);
                    cmd.ExecuteNonQuery();
                    
                }
            }


            return View();
        }
    }
}