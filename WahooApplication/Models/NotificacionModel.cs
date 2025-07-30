using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;

namespace WahooApplication.Models
{
    public class NotificacionModel : CommonModel
    {
        public string DescripcionNotificacion { get; set; }
        public bool Enviada { get; set; }
        public int UsuarioId { get; set; }
    }
}
