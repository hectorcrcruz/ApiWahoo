using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;
using WahooDomain;

namespace WahooApplication.Models
{
    public class CalificacionModel : CommonModel
    {
        public int PuntajeCalificacion { get; set; }
        public int ParametroEvaluacionId { get; set; }
        public int CriterioEvaluacionId { get; set; }
        public int UsuarioId { get; set; }
    }
}
