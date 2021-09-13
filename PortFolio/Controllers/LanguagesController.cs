using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolio.Controllers
{
    public class LanguagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
