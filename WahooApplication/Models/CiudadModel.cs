using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;

namespace WahooApplication.Models
{
    public class CiudadModel : CommonModel
    {
        public string NombreCiudad { get; set; }
        public int DepartamentoId { get; set; }
    }
}
