using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Models.CommonVm
{
    public class CommonModel
    {
        public int Id { get; set; }
        public int Estado { get; set; }
        public string UsuarioAdd { get; set; }
        public string? UsuarioUp { get; set; }
        public DateTime FechaAdd { get; set; }
        public DateTime? FechaUp { get; set; }
    }
}
