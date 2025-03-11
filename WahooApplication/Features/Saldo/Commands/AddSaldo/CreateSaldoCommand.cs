using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Saldo.Commands.AddSaldo
{
    public class CreateSaldoCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoFinal { get; set; }
        public decimal SaldoActual { get; set; }
        public int UsuarioId { get; set; }
        public string UsuarioAdd { get; set; }
        public int Estado { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
