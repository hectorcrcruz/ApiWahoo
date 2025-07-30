using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;

namespace WahooApplication.Models
{
    public class ChatModel : CommonModel
    {
        public string Mensaje { get; set; }
        public string DocumentoSoporte { get; set; }
        public int Emisor { get; set; }
        public int Receptor { get; set; }
        public string Documento { get; set; }
    }
}
