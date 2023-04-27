using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace LeapStageWeb.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string userName, int ID = 000)
        {
            ViewData["userName"] = userName;
            ViewData["ID"] = ID;

            return View();
        }
    }
}