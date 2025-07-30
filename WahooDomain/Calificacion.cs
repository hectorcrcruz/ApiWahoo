using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class Calificacion : Entity
    {
        public int PuntajeCalificacion { get; set; }
        public int ParametroEvaluacionId { get; set; }
        public ParametroEvaluacion ParametroEvaluacion { get; set; }
        public int CriterioEvaluacionId { get; set; }
        public CriterioEvaluacion CriterioEvaluacion { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
