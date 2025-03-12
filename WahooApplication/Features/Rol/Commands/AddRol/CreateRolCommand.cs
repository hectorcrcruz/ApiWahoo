using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Rol.Commands.AddRol
{
    public class CreateRolCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionRol { get; set; }
        public int ModuloId { get; set; }
        public string UsuarioAdd { get; set; }
        public int Estado { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
