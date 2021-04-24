using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hogarbaik.Controllers
{
    public class ProyectosController : Controller
    {
        public IActionResult Proyectos()
        {
            return View();
        }
        public IActionResult FormularioProyecto()
        {
            return View();
        }
        public IActionResult ModificarProyecto()
        {
            return View();
        }
        public IActionResult ControlProyectos()
        {
            return View();
        }
        public IActionResult VerControlProyectos ()
        {
            return View();
        }
    }
}
