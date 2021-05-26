using System;
using System.Collections.Generic;

#nullable disable

namespace hogarbaik.BD
{
    public partial class Proyecto
    {
        public Proyecto()
        {
            Bitacoras = new HashSet<Bitacora>();
        }

        public int PkCodigoProyecto { get; set; }
        public string NombreProyecto { get; set; }
        public string Descripcion { get; set; }
        public string Responsable { get; set; }
        public int PresupuestoInicial { get; set; }
        public DateTime FechaInicioProyecto { get; set; }
        public int? IdDetalleProyecto { get; set; }

        public virtual DetalleProyecto IdDetalleProyectoNavigation { get; set; }
        public virtual ICollection<Bitacora> Bitacoras { get; set; }
    }
}
