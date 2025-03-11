using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Log.Commands.AddLog
{
    public class CreateLogCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionLog { get; set; }
        public int CategoriaLogId { get; set; }
        public string UsuarioAdd { get; set; }
        public int Estado { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
