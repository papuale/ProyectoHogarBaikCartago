using System;
using System.Collections.Generic;

#nullable disable

namespace hogarbaik.BD
{
    public partial class InventarioInmueble
    {
        public InventarioInmueble()
        {
            Bitacoras = new HashSet<Bitacora>();
        }

        public int PkCodigoInmueble { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string Serie { get; set; }
        public int Valor { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public string Adquisicion { get; set; }

        public virtual ICollection<Bitacora> Bitacoras { get; set; }
    }
}
