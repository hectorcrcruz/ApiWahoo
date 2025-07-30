using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;

namespace WahooApplication.Models
{
    public class DepartamentoModel : CommonModel
    {
        public string NombreDepartamento { get; set; }
        public int PaisId { get; set; }
    }
}
