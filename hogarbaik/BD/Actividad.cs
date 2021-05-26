using System;
using System.Collections.Generic;

#nullable disable

namespace hogarbaik.BD
{
    public partial class Actividad
    {
        public Actividad()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int PkCodigoActividad { get; set; }
        public string NombreEvento { get; set; }
        public string LugarEvento { get; set; }
        public string DescripcionEvento { get; set; }
        public string ImagenEvento { get; set; }
        public DateTime FechaEvento { get; set; }
        public string HoraEvento { get; set; }
        public int TelefonoEvento { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
