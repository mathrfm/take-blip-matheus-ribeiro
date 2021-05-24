using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebChatClient.Model
{
    class Mensagem
    {
        public string usuario { get; set; }
        public string mensagem { get; set; }
        public string usuarioDestino { get; set; }
    }
}
