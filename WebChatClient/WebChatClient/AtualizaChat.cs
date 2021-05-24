using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebChatClient.Model;
using Newtonsoft.Json;

namespace WebChatClient
{
    class AtualizaChat
    {
        public async Task<string> BuscaChat(string usuario)
        {
            string ret = "ret";

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new System.Uri("http://localhost:5000/");
           
            HttpResponseMessage retorno = await httpClient.GetAsync($"WebChat?usuario=" + usuario);

            var webChat = await retorno.Content.ReadAsStringAsync();

            var webChatList = JsonConvert.DeserializeObject<List<MensagemUnica>>(webChat);

            foreach (MensagemUnica i in webChatList)
                Console.WriteLine(i.mensagem);


            return ret;
        }
       
    }
}
