using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hogarbaik.Entidades
{
    public class clsNino
    {
        public int PkCedula { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string ArchivoConstancia { get; set; }
        public string Estado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string EncargadoIngreso { get; set; }
        public int CedulaEncargado { get; set; }
        public string MotivoIngreso { get; set; }
        public string UbicacionOficina { get; set; }
        public int TelefonoOficina { get; set; }
        public string CorreoOficina { get; set; }
        public string ArchivoIngreso { get; set; }
        public DateTime? FechaEgreso { get; set; }
        public string EncargadoEgreso { get; set; }
        public int CedulaEncargadoEgreso { get; set; }
        public string DetalleEgreso { get; set; }
        public string DestinoEgreso { get; set; }
        public string ContactoEgreso { get; set; }
        public string ArchivoEgreso { get; set; }
        public int? IdCodigoEducativo { get; set; }
        public int? IdCodigoMedico { get; set; }
    }
}
