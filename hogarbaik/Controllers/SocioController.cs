using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hogarbaik.Controllers
{
    public class SocioController : Controller
    {
        public IActionResult FormularioSocio()
        {
            return View();
        }

        public IActionResult Solicitudes()
        {
            ViewBag.MensajeAprobado = null;
            ViewBag.MensajeNegado = null;
            return View();
        }

        public IActionResult SolicitudesAprobadas()
        {
            return View();
        }

        public IActionResult SolicitudesDenegadas()
        {
            return View();
        }

     
        public ActionResult AprobadoNegado(string submit)
        {
            if (submit == "Aprobado")
            {
                ViewBag.MensajeAprobado = "Solicitud de socio aprobada";

            }
            else if (submit == "Negado")
            {
                ViewBag.MensajeNegado = "Solicitud de socio negada";

            }


            return View("Solicitudes");


        }
    }
}
