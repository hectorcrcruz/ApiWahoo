using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class TiempoFase : Entity
    {
        public DateTime HoraCambioFase { get; set; }
        public int DomicilioId { get; set; }
        public Domicilio Domicilio { get; set; }
    }
}
