using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Login.Commands.AddLogin
{
    public class LoginCommand : IRequest<LoginModel>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
