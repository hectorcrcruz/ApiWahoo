using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;
using WahooDomain;

namespace WahooApplication.Models
{
    public class EntidadModel : CommonModel
    {
        public string DescripcionEntidad { get; set; }
        public int TipoEntidadId { get; set; }
        public int MedioPagoId { get; set; }
    }
}
