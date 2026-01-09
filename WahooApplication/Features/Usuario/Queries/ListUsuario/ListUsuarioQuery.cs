using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Usuario.Queries.ListUsuario
{
    public class ListUsuarioQuery : IRequest<List<UsuarioModel>>
    {
        public ListUsuarioQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
