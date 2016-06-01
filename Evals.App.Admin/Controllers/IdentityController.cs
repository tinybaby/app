using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Evals.App.Admin.Controllers
{
    public class IdentityController : Controller
    {
        [Route("/user/list")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
