using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class Entidad : Entity
    {
        public string DescripcionEntidad { get; set; }
        public int TipoEntidadId { get; set; }
        public TipoEntidad TipoEntidad { get; set; }
        public int MedioPagoId { get; set; }
        public MedioPago MedioPago { get; set; }
    }
}
