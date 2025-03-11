using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;
using WahooDomain;

namespace WahooApplication.Models
{
    public class DomicilioModel : CommonModel
    {
        public string DescripcionDomicilio { get; set; }
        public int UsuarioId { get; set; }
        public int FaseDomicilioId { get; set; }
        public int ProductoId { get; set; }
        public DateTime? FechaAceptaDomiciliario { get; set; }
        public DateTime? FechaAceptaEntidad { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public int? AceptaEntidad { get; set; }
        public int? AceptaDomiciliario { get; set; }
        public bool? DomicilioExitoso { get; set; }
    }
}
