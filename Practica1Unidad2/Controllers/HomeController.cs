using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practica1Unidad2.Models;

namespace Practica1Unidad2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(Datos n)
        {
            return View(n);
        }
        public IActionResult Capturar()
        {
            return View();
        }
    }
}
