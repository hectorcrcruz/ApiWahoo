using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.CategoriaLog.Commands.AddCategoriaLogs
{
    public class CreateCategoriaLogCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionCategoriaLog { get; set; }
        public string UsuarioAdd { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
