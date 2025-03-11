using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Rol.Commands.UpRol
{
    public class UpdateRolCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionRol { get; set; }
        public int ModuloId { get; set; }
        public string UsuarioUp { get; set; }
        public int Estado { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
