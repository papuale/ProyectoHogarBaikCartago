using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hogarbaik.Controllers
{
    public class InicioSesionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IniciarSesion()
        {
            return View("~/Views/Inicio/Inicio.cshtml");
            
        }
        
    }
}
