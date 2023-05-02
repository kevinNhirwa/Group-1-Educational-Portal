using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LeapStageWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index([Bind("Id,fullName,email,phone,password")] Parent parent)
        {
            return View();
        }
    }
}