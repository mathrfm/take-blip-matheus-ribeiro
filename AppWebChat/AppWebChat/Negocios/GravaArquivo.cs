using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebChat.Negocios
{
    public class GravaArquivo
    {
        public async Task GravaArq(string usuario, string mensagem, string usuarioDestino)
        {
            if (usuarioDestino == "publico")
            {
                StreamWriter file = new("WebChat.txt", append: true);
                await file.WriteLineAsync(usuario + " : " + mensagem);
                file.Close();
            }
            else
            {
                StreamWriter file = new(usuarioDestino + ".txt", append: true);
                await file.WriteLineAsync(usuario + " : " + mensagem);
                file.Close();
            }
            
        }

    }
}
