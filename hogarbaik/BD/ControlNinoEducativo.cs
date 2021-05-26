using System;
using System.Collections.Generic;

#nullable disable

namespace hogarbaik.BD
{
    public partial class ControlNinoEducativo
    {
        public ControlNinoEducativo()
        {
            InformacionNinos = new HashSet<InformacionNino>();
        }

        public int PkCodigoEducativo { get; set; }
        public string GradoAcademico { get; set; }
        public string Observacion { get; set; }
        public string CentroEducativo { get; set; }
        public string ArchivoEducativo { get; set; }
        public string Lateralidad { get; set; }
        public string ProcesoEducativo { get; set; }
        public string Discapacidad { get; set; }
        public string FormaComunicacion { get; set; }

        public virtual ICollection<InformacionNino> InformacionNinos { get; set; }
    }
}
