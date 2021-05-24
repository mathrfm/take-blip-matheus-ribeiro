using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebChat.Model
{
    public class Mensagem
    {
        public string usuario { get; set; }
        public string mensagem { get; set; }
        public string usuarioDestino { get; set; }
    }
}
