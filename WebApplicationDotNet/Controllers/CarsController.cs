using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationDotNet.Models;

namespace WebApplicationDotNet.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            var model = new CarModel()
            {
                WebApplicationDotNet = WebApplicationDotNet
            };
             
            return View(model);
        }

    }
}
