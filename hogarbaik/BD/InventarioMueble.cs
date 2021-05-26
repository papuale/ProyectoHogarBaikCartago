using System;
using System.Collections.Generic;

#nullable disable

namespace hogarbaik.BD
{
    public partial class InventarioMueble
    {
        public InventarioMueble()
        {
            Bitacoras = new HashSet<Bitacora>();
        }

        public int PkCodigoMueble { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string Placa { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public string Adquisicion { get; set; }

        public virtual ICollection<Bitacora> Bitacoras { get; set; }
    }
}
