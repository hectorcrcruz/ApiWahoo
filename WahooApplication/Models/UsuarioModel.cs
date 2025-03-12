using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;
using WahooDomain;

namespace WahooApplication.Models
{
    public class UsuarioModel : CommonModel
    {
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public int TelefonoUsuario { get; set; }
        public DateTime ExpedicionCedula { get; set; }
        public string DireccionUsuario { get; set; }
        public string PlacaMoto { get; set; }
        public string LicenciaConduccion { get; set; }
        public int HorarioUsuario { get; set; }
        public int FormaPago { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Documentos { get; set; }
        public string Correo { get; set; }
        public int Circulacion { get; set; }
        public string CausacionPagos { get; set; }
        public int RolId { get; set; }
        public int TipoIdentificacionId { get; set; }
    }
}
