using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Evals.App.Web.Framework.Authorization;

namespace Evals.App.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/signin")]
        public IActionResult SignIn()
        {

            return View();
        }

        [Route("/signin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignIn(string username, string password)
        {
            return View();
        }
    }
}
