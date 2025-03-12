using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain;

namespace WahooApplication.Features.Catalogo.Commands.UpCatalogo
{
    public class UpdateCatalogoCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionCatalogo { get; set; }
        public int ItemId { get; set; }
        public int? EntidadId { get; set; }
        public int Estado { get; set; }
        public string UsuarioUp { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
