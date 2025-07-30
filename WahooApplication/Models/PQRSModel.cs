using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;
using WahooDomain;

namespace WahooApplication.Models
{
    public class PQRSModel : CommonModel
    {
        public string DescripcionPQRS { get; set; }
        public int UsuarioId { get; set; }
        public int TipoPQRSId { get; set; }
    }
}
