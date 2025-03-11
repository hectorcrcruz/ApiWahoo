using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Permiso.Commands.AddPermiso
{
    public class CreatePermisoCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionPermiso { get; set; }
        public string UsuarioAdd { get; set; }
        public int Estado { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
