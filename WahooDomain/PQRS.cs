using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class PQRS : Entity
    {
        public string DescripcionPQRS { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int TipoPQRSId { get; set; }
        public TipoPQRS TipoPQRS { get; set; }
    }
}
