using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class Horario : Entity
    {
        public string DescripcionHorario { get; set; }
        public string FranjaHorario { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string DiasLaborales { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int DiaId { get; set; }
        public Dia Dia { get; set; }

    }
}
