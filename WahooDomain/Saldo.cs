using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class Saldo : Entity
    {
        public decimal SaldoInicial { get; set; }
        public decimal SaldoFinal { get;set; }
        public decimal SaldoActual { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
