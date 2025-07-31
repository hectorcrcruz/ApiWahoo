using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Models
{
    public class LoginModel
    {
        public string Id { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string Token { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Message { get; set; }
    }
}
