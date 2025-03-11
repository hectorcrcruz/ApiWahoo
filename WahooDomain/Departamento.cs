using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class Departamento : Entity
    {
        public string NombreDepartamento { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
    }
}
