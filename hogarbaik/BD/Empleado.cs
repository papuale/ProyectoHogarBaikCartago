using System;
using System.Collections.Generic;

#nullable disable

namespace hogarbaik.BD
{
    public partial class Empleado
    {
        public Empleado()
        {
            Bitacoras = new HashSet<Bitacora>();
        }

        public int PkCedula { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Provincia { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public int? IdCodigoActividad { get; set; }
        public int? IdCodigoRol { get; set; }

        public virtual Actividad IdCodigoActividadNavigation { get; set; }
        public virtual Rol IdCodigoRolNavigation { get; set; }
        public virtual ICollection<Bitacora> Bitacoras { get; set; }
    }
}
