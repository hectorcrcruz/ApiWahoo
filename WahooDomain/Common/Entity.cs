using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooDomain.Common
{
    public abstract class Entity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Estado { get; set; }
        public string UsuarioAdd{ get; set; }
        public string? UsuarioUp { get; set; }
        public DateTime FechaAdd { get; set; }
        public DateTime? FechaUp { get; set;}

    }
}
