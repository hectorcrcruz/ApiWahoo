using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Login.Commands.AddLogin
{
    public class CreateLoginCommand : IRequest<LoginModel>
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
