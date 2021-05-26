using System;
using System.Collections.Generic;

#nullable disable

namespace hogarbaik.BD
{
    public partial class Rol
    {
        public Rol()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int PkRol { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
