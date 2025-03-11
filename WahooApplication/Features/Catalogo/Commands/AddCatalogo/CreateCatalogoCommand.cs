using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;
using WahooDomain;

namespace WahooApplication.Features.Catalogo.Commands.AddCatalogo
{
    public class CreateCatalogoCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionCatalogo { get; set; }
        public int ItemId { get; set; }
        public int? EntidadId { get; set; }
        public int Estado { get; set; }
        public string UsuarioAdd { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
