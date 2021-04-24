using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hogarbaik.Controllers
{
    public class ActividadesController : Controller
    {
        public IActionResult Actividades()
        {
            return View();
        }

        public IActionResult VerActividades()
        {
            return View();
        }
        public IActionResult EditarActividades()
        {
            return View();
        }

    }
}
