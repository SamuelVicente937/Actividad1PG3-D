using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBlazor.Entities
{
    public class RepresentanteListCLS
    {
        public int Num_empl { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string Cargo { get; set; } = null!;
        public DateTime FechaContrato { get; set; }
        public double Cuota { get; set; }
        public double Venta { get; set; }

    }
}
