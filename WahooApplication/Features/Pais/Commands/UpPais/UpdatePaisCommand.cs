using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Pais.Commands.UpPais
{
    public class UpdatePaisCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string NombrePais { get; set; }
        public string UsuarioUp { get; set; }
        public int Estado { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
