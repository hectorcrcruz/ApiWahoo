using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Departamento.Commands.AddDepartamento
{
    public class CreateDepartamentoCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string NombreDepartamento { get; set; }
        public int PaisId { get; set; }
        public int Estado { get; set; }
        public string UsuarioAdd { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
