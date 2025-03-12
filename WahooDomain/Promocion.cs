using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class Promocion : Entity
    {
        public string DescripcionPromocion { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public DateTime FechaInicioPromocion { get; set; }
        public DateTime FechaFinPromocion { get; set; }
        public byte ImagenPromocion { get; set; }
        public string CodigoPromocional { get; set; }
        public int TipoPromocionId { get; set; }
        public TipoPromocion TipoPromocion { get; set; }

    }
}
