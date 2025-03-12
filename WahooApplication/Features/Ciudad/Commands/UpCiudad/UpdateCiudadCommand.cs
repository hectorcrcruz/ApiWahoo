using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Ciudad.Commands.UpCiudad
{
    public class UpdateCiudadCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string NombreCiudad { get; set; }
        public int DepartamentoId { get; set; }
        public int Estado { get; set; }
        public string UsuarioUp { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
