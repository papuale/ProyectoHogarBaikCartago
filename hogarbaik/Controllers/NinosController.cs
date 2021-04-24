using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hogarbaik.Controllers
{
    public class NinosController : Controller
    {
        public IActionResult NinosActivos()
        {
            return View();
        }

        public IActionResult NinosInactivos()
        {
            return View();
        }

        public IActionResult VerExpediente()
        {
            return View();
        }

        public IActionResult NuevoExpediente()
        {
            return View();
        }

        public IActionResult Educativo()
        {
            return View();
        }

        public IActionResult Medico()
        {
            return View();
        }
    }
}
