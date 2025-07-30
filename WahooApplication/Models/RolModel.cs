using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WahooApplication.Models.CommonVm;
namespace WahooApplication.Models
{
    public class RolModel : CommonModel
    {
        public string DescripcionRol { get; set; }
        public int ModuloId { get; set; }
    }
}
