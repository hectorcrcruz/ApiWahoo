using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class Catalogo : Entity
    {
        public string DescripcionCatalogo { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int? EntidadId { get; set; }
    }
}
