using System;
using System.Collections.Generic;

#nullable disable

namespace hogarbaik.BD
{
    public partial class DetalleProyecto
    {
        public DetalleProyecto()
        {
            Proyectos = new HashSet<Proyecto>();
        }

        public int PkDetalleProyecto { get; set; }
        public string Material { get; set; }
        public string ServicioExterno { get; set; }
        public string DuracionProyecto { get; set; }
        public DateTime FechaFinalizacion { get; set; }

        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
