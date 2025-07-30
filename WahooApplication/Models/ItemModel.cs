using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;

namespace WahooApplication.Models
{
    public class ItemModel : CommonModel
    {
        public string DescripcionItem { get; set; }
        public int CantidadItem { get; set; }
        public string UnidadMedidaItem { get; set; }
    }
}
