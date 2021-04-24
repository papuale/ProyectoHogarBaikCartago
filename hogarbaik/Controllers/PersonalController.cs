using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hogarbaik.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Empleado()
        {
            return View();
        }

        public IActionResult FormularioEmpleado()
        {
            ViewBag.MensajeAgregar = null;
            return View();
        }

        public IActionResult ModificarEmpleado()
        {
            return View();
        }

        //Metodo mensaje
        public IActionResult AgregarEmpleado()
        {
            MensajeLleno();
            return View("FormularioEmpleado");
        }



        public void MensajeLleno()
        {
            ViewBag.MensajeAgregar = "Empleado agregado con éxito";
        }
    }
}
