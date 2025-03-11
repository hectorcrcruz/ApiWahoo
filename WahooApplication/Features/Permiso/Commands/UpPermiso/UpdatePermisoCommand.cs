using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Permiso.Commands.UpPermiso
{
    public class UpdatePermisoCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionPermiso { get; set; }
        public string UsuarioUp { get; set; }
        public int Estado { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
