using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;

namespace WahooApplication.Models
{
    public class LogModel : CommonModel
    {
        public string DescripcionLog { get; set; }
        public int CategoriaLogId { get; set; }
    }
}
