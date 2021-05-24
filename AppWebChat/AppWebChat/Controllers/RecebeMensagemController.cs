using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppWebChat.Model;
using AppWebChat.Negocios;
using Newtonsoft.Json;

namespace AppWebChat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecebeMensagemController : Controller
    {

        private readonly ILogger<RecebeMensagemController> _logger;

        public RecebeMensagemController(ILogger<RecebeMensagemController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Mensagem request)
        {
            var usuario = request.usuario;
            var mensagem = request.mensagem;
            var usuarioDestino = request.usuarioDestino;
            
            var retorno = "[{'message':'mensagem registrada'}]";
            var ret = new JsonResult(retorno);

            GravaArquivo grava = new GravaArquivo();

            await grava.GravaArq(usuario,mensagem,usuarioDestino);

            return ret;
        }
    }
}
