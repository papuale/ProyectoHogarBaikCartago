using System;
using System.Collections.Generic;

#nullable disable

namespace hogarbaik.BD
{
    public partial class ControlNinoMedico
    {
        public ControlNinoMedico()
        {
            InformacionNinos = new HashSet<InformacionNino>();
        }

        public int PkCodigoMedico { get; set; }
        public string Condicion { get; set; }
        public string DescripcionCondicion { get; set; }
        public string Medicamento { get; set; }
        public string Indicacion { get; set; }
        public string Discapacidad { get; set; }
        public string Enfermedad { get; set; }
        public string ArchivoCarnetVacunas { get; set; }
        public string ArchivoCarnetCitas { get; set; }
        public string ArchivoEvolucion { get; set; }

        public virtual ICollection<InformacionNino> InformacionNinos { get; set; }
    }
}
