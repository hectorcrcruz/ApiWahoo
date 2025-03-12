using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;
using WahooDomain;

namespace WahooApplication.Models
{
    public class CatalogoModel : CommonModel
    {
        public string DescripcionCatalogo { get; set; }
        public int ItemId { get; set; }
        public int? EntidadId { get; set; }
    }
}
