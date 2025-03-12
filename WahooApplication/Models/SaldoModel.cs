using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;

namespace WahooApplication.Models
{
    public class SaldoModel : CommonModel
    {
        public decimal SaldoInicial { get; set; }
        public decimal SaldoFinal { get; set; }
        public decimal SaldoActual { get; set; }
        public int UsuarioId { get; set; }
    }
}
