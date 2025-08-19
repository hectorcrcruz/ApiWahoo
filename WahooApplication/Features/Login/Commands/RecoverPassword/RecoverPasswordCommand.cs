using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Login.Commands.RecoverPassword
{
    public class RecoverPasswordCommand : IRequest<RecoverPasswordModel>
    {
        public string Login { get; set; }

    }
}
