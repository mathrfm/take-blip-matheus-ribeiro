using AppWebChat.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebChat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebChatController : Controller
    {
        private readonly ILogger<WebChatController> _logger;

        public WebChatController(ILogger<WebChatController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get(string usuario)
        {

            string[] linhasPublico = System.IO.File.ReadAllLines(@"WebChat.txt");
            var mensagemUnica = new MensagemUnica();
            var mensagens = new List<MensagemUnica>();

            mensagemUnica = new MensagemUnica();
            mensagemUnica.mensagem = "--------Web Chat--------";
            mensagens.Add(mensagemUnica);

            foreach (string i in linhasPublico)
            {
                mensagemUnica = new MensagemUnica();
                mensagemUnica.mensagem = i;
                mensagens.Add(mensagemUnica);
            }
            if (System.IO.File.Exists(usuario + ".txt"))
            {
                mensagemUnica = new MensagemUnica();
                mensagemUnica.mensagem = "--------Mensagens Privadas--------";
                mensagens.Add(mensagemUnica);

                string[] linhasUsuario = System.IO.File.ReadAllLines(usuario + ".txt");
                foreach (string i in linhasUsuario)
                {
                    mensagemUnica = new MensagemUnica();
                    mensagemUnica.mensagem = i;
                    mensagens.Add(mensagemUnica);
                }
            }

            var retorno = JsonConvert.SerializeObject(mensagens, Formatting.Indented);
   
            return retorno;
        }

    }
}
