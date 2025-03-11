using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Log.Commands.UpLog
{
    public class UpdateLogCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionLog { get; set; }
        public int CategoriaLogId { get; set; }
        public string UsuarioUp { get; set; }
        public int Estado { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
