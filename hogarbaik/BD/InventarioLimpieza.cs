using System;
using System.Collections.Generic;

#nullable disable

namespace hogarbaik.BD
{
    public partial class InventarioLimpieza
    {
        public InventarioLimpieza()
        {
            Bitacoras = new HashSet<Bitacora>();
        }

        public int PkCodigoLimpieza { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string NombreBenefactor { get; set; }
        public string NombreBeneficiado { get; set; }
        public string Adquisicion { get; set; }

        public virtual ICollection<Bitacora> Bitacoras { get; set; }
    }
}
