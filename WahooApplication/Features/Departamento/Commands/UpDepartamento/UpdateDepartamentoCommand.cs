using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Departamento.Commands.UpDepartamento
{
    public class UpdateDepartamentoCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string NombreDepartamento { get; set; }
        public int PaisId { get; set; }
        public int Estado { get; set; }
        public string UsuarioUp { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
