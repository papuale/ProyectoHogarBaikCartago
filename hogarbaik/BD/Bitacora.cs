using System;
using System.Collections.Generic;

#nullable disable

namespace hogarbaik.BD
{
    public partial class Bitacora
    {
        public int PkCodigoBitacora { get; set; }
        public string Movimiento { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public int? IdCedulaNino { get; set; }
        public int? IdCodigoProyecto { get; set; }
        public int? IdCedulaEmpleado { get; set; }
        public int? IdCodigoLimpieza { get; set; }
        public int? IdCodigoAlimentacion { get; set; }
        public int? IdCodigoInmueble { get; set; }
        public int? IdCodigoMueble { get; set; }
        public int? IdCedulaSocio { get; set; }

        public virtual Empleado IdCedulaEmpleadoNavigation { get; set; }
        public virtual InformacionNino IdCedulaNinoNavigation { get; set; }
        public virtual Socio IdCedulaSocioNavigation { get; set; }
        public virtual InventarioAlimentacion IdCodigoAlimentacionNavigation { get; set; }
        public virtual InventarioInmueble IdCodigoInmuebleNavigation { get; set; }
        public virtual InventarioLimpieza IdCodigoLimpiezaNavigation { get; set; }
        public virtual InventarioMueble IdCodigoMuebleNavigation { get; set; }
        public virtual Proyecto IdCodigoProyectoNavigation { get; set; }
    }
}
