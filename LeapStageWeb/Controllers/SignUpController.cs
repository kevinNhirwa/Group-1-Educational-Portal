﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LeapStageWeb.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}