using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class Rol : Entity
    {
        public string DescripcionRol { get; set; }
        public int ModuloId { get; set; }
        public Modulo Modulo { get; set; }
    }
}
