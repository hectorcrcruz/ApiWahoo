using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class Log : Entity
    {
        public string DescripcionLog { get; set; }
        public int CategoriaLogId { get; set; }
        public CategoriaLog CategoriaLog { get; set; }
    }
}
