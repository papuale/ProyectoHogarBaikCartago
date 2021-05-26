using System;
using System.Collections.Generic;

#nullable disable

namespace hogarbaik.BD
{
    public partial class Socio
    {
        public Socio()
        {
            Bitacoras = new HashSet<Bitacora>();
        }

        public int PkCedulaSocio { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Provincia { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public int DonacionMensual { get; set; }
        public string FormaPago { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Bitacora> Bitacoras { get; set; }
    }
}
