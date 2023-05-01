using System;
using System.Collections.Generic;
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
        public IActionResult Create([Bind("Id,fullName,email,password,phoneNum,isParent")] Parent parent)
        {

            return View();
        }
    }
}