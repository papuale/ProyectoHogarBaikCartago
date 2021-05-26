using hogarbaik.BD;
using hogarbaik.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hogarbaik.Controllers
{
    public class NinosController : Controller
    {
        public ActionResult NinosActivos()
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
   
        [HttpPost]
        public IActionResult RegistroNino(clsNino infoNino)
        {
            String fecha = "2005-05-25";
            using (var BD = new bdhogarbaikContext())
            {
                InformacionNino Ninobd = new InformacionNino();
                Ninobd.PkCedula = infoNino.PkCedula;
                Ninobd.Nombre = infoNino.Nombre;
                Ninobd.PrimerApellido = infoNino.PrimerApellido;
                Ninobd.SegundoApellido = infoNino.SegundoApellido;
                Ninobd.FechaNacimiento = DateTime.Parse(fecha);
                Ninobd.Edad = 5;
                Ninobd.ArchivoConstancia = "Constancia.pf";
                Ninobd.Estado = "Activo";
                Ninobd.FechaIngreso = DateTime.Parse(fecha);
                Ninobd.EncargadoIngreso = "Jorge Carrascal";
                Ninobd.CedulaEncargado = 302560879;
                Ninobd.MotivoIngreso = "Abandono";
                Ninobd.UbicacionOficina = "Cartago, Costa Rica";
                Ninobd.TelefonoOficina = 25528214;
                Ninobd.CorreoOficina = "sad@gmail.com";
                Ninobd.ArchivoIngreso = "Ingreso.pdf";
                Ninobd.FechaEgreso = DateTime.Parse(fecha);
                Ninobd.CedulaEncargadoEgreso = 123456789;
                Ninobd.EncargadoEgreso = "Bryan Ruiz";
                Ninobd.DetalleEgreso = "Adopcion";
                Ninobd.DestinoEgreso = "Casa familiar";
                Ninobd.ContactoEgreso = "25849631";
                Ninobd.ArchivoEgreso = "Egreso.pdf";
                //Ninobd.IdCodigoEducativo = 5;
                //Ninobd.IdCodigoMedico = 5;



                BD.Add(Ninobd);
                BD.SaveChanges();


            }
                return RegistroNino();

        }

        public ActionResult RegistroNino()
        {
            return View("NinosActivos");


        }
    }
}
