using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom9.Docker_Kubernet.Demo.WebUI.Controllers
{
    public class CSSAnimationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
