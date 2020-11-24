using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nhom9.Docker_Kubernet.Demo.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom9.Docker_Kubernet.Demo.WebUI.Controllers
{
    public class DashboardsController : Controller
    {
        private readonly ILogger<DashboardsController> _logger;

        public DashboardsController(ILogger<DashboardsController> logger)
        {
            _logger = logger;
        }
        public IActionResult Dashboard_1()
        {
            return View();
        }

        public IActionResult Dashboard_2()
        {
            return View();
        }

        public IActionResult Dashboard_3()
        {
            return View();
        }

        public IActionResult Dashboard_4()
        {
            return View();
        }

        public IActionResult Dashboard_4_1()
        {
            return View();
        }

        public IActionResult Dashboard_5()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
