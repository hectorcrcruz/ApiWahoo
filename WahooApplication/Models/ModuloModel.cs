using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;

namespace WahooApplication.Models
{
    public class ModuloModel :CommonModel
    {
        public string DescripcionModulo { get; set; }
        public int PermisoId { get; set; }
    }
}
