using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortFolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolio.Controllers
{
    [Route("")]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("[action]")]
        public IActionResult Privacy()
        {
            return View();
        }
        [Route("[action]")]
        public IActionResult AboutMe()
        {
            return View();
        }
        [Route("[action]")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
