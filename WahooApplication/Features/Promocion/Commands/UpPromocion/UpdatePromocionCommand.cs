using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Promocion.Commands.UpPromocion
{
    public class UpdatePromocionCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionPromocion { get; set; }
        public int ProductoId { get; set; }
        public DateTime FechaInicioPromocion { get; set; }
        public DateTime FechaFinPromocion { get; set; }
        public byte ImagenPromocion { get; set; }
        public string CodigoPromocional { get; set; }
        public int TipoPromocionId { get; set; }
        public string UsuarioUp { get; set; }
        public int Estado { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
