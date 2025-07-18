using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class Transaccion : Entity
    {
        public string DescripcionTransaccion { get; set; }
        public int TipoTransaccionId { get; set; }
        public TipoTransaccion TipoTransaccion { get; set; }
        public int EntidadId { get; set; }
        public Entidad Entidad { get; set; }
        public int DomicilioId { get; set; }
        public Domicilio Domicilio { get; set; }
        public string DescripcionAdicional { get; set; }
        public int MedioPagoId { get; set; }
        public int Unidades { get; set; }
        public int Valor { get; set; }
        public string Direccion { get; set; }
    }
}
