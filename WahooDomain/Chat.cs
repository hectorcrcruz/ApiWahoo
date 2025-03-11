using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class Chat : Entity
    {
        public string Mensaje { get; set; }
        public byte DocumentoSoporte { get; set; }
        public int Emisor { get; set; }
        public int Receptor { get; set; }
        public byte Documento { get; set; }    
    }
}
