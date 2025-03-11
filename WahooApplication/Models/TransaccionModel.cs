using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;
using WahooDomain;

namespace WahooApplication.Models
{
    public class TransaccionModel : CommonModel
    {
        public string DescripcionTransaccion { get; set; }
        public int TipoTransaccionId { get; set; }
        public int EntidadId { get; set; }
        public int DomicilioId { get; set; }
        public string DescripcionAdicional { get; set; }
    }
}
