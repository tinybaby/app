using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Evals.App.Web.Framework.Authorization;
using Evals.App.Infrastructure.Cache;

namespace Evals.App.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICacheManager _cacheManger;

        public HomeController(ICacheManager cacheManger)
        {
            _cacheManger = cacheManger;
        }

        public IActionResult Index()
        {
            _cacheManger.Save("Abs", DateTime.Now);
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
