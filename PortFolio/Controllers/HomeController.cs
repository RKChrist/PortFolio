using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortFolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Humanizer.In;
using System.Xml.Linq;
using System.Runtime.InteropServices.ComTypes;
using static System.Net.WebRequestMethods;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting;

namespace PortFolio.Controllers
{
    [Route("")]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IWebHostEnvironment _env;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
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
        [HttpPost, ActionName("AboutMe")]
        public  IActionResult DownloadCVAsync()
        {
            string fileName = "Files" + "\\" + "Rune-Kennet-Christensen-CV .docx";
            var filepath = _env.ContentRootPath + "\\" + fileName;
            var fileExists = System.IO.File.Exists(filepath);
            if (fileExists)
            {
                var fs = System.IO.File.OpenRead(filepath);
                return File(fs, "application/pdf", "Rune-Kennet-Christensen-CV - Danish.docx");
            }
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
