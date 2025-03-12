using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class Modulo : Entity
    {
        public string DescripcionModulo { get; set; }
        public int PermisoId { get; set; }
        public Permiso Permiso { get; set; }
    }
}
