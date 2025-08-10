using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class Parametrizacion : Entity
    {
        public string NombreApp { get; set; }
        public string Footer { get; set;}
        public string Logo { get; set;}
        public string BackgroundImagen { get; set;}
        public string ColorPrimario { get; set;}
        public string ColorSecundario { get; set; }
        public string ColorTerciario { get; set; }
        public string ColorBotonCrear { get; set; }
        public string ColorBotonActualizar { get; set; }
        public string ColorBotonEliminar { get; set; }
        public string ColorTexto { get; set; }
        public string TipoLetra { get; set; }
        public string TextoPrimario { get; set; }
        public string TextoSecundario { get; set; }
        public string TextoTerciario { get; set; }
        public string TextoCuaternario { get; set; }

    }
}
