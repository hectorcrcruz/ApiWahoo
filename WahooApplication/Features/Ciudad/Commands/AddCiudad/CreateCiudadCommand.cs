using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Ciudad.Commands.AddCiudad
{
    public class CreateCiudadCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string NombreCiudad { get; set; }
        public int DepartamentoId { get; set; }
        public int Estado { get; set; }
        public string UsuarioAdd { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
