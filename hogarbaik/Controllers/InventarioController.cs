using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hogarbaik.Controllers
{
    public class InventarioController : Controller
    {

        //Vistas de los inventarios, de modificar o formulario
        public IActionResult InventarioAlimentacion()
        {
            return View();
        }

        public IActionResult InventarioLimpieza()
        {
            return View();
        }

        public IActionResult InventarioMuebles()
        {
            return View();
        }

        public IActionResult InventarioInmuebles()
        {
            return View();
        }

        public IActionResult FormularioLimpieza()
        {

            MensajeAgregadoVacio();
            return View();
        }

        public IActionResult FormularioAlimentacion()
        {
            MensajeAgregadoVacio();
            return View();
        }

        public IActionResult FormularioMuebles()
        {
            MensajeAgregadoVacio();
            return View();
        }

        public IActionResult FormularioInmuebles()
        {
            MensajeAgregadoVacio();
            return View();
        }

        public IActionResult ModificarAlimentacion()
        {
            return View();
        }

        public IActionResult ModificarLimpieza()
        {
            return View();
        }

        public IActionResult ModificarMuebles()
        {
            return View();
        }

        public IActionResult ModificarInmuebles()
        {
            return View();
        }

        //Metodos con la notificacion y agregar a la BD los datos ingresados en el formulario
        public IActionResult AgregarAlimentacion()
        {
            MensajeAgregado();
            return View("FormularioAlimentacion");
        }

        public IActionResult AgregarLimpieza()
        {
            MensajeAgregado();
            return View("FormularioLimpieza");
        }

        public IActionResult AgregarInmuebles()
        {
            MensajeAgregado();
            return View("FormularioInmuebles");
        }

        public IActionResult AgregarMuebles()
        {
            MensajeAgregado();
            return View("FormularioMuebles");
        }

        

        //Mensajes de notificación

        public void MensajeAgregado()
        {
            ViewBag.MensajeAgregar = "Datos agregados éxitosamente";
        }

        public void MensajeAgregadoVacio()
        {
            ViewBag.MensajeAgregar = null;
        }

       




    }
}
