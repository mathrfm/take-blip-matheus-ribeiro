using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebChatClient.Model;

namespace WebChatClient
{
    class EnviaMensagem
    {
        public void Envia(string texto, string usuario, string usuarioDestino)
        {
            var mensagem = new Mensagem();

            mensagem.mensagem = texto;
            mensagem.usuario = usuario;
            mensagem.usuarioDestino = usuarioDestino;

            var json = JsonConvert.SerializeObject(mensagem);

            var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");

            HttpClient httpClient = new HttpClient();

            var retorno = httpClient.PostAsync("http://localhost:5000/RecebeMensagem", content).Result;

            retorno.EnsureSuccessStatusCode();
        }
    }
}
