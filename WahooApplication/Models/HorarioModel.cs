using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;
using WahooDomain;

namespace WahooApplication.Models
{
    public class HorarioModel : CommonModel
    {
        public string DescripcionHorario { get; set; }
        public string FranjasHorario { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string DiasLaborales { get; set; }
        public int UsuarioId { get; set; }
        public int DiaId { get; set; }
    }
}
