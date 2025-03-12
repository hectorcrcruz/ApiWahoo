using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.TipoPQRS.Commands.AddTipoPQRS
{
    public class CreateTipoPQRSCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionTipoPQRS { get; set; }
        public string UsuarioAdd { get; set; }
        public int Estado { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
