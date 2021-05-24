using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebChatClient
{
    class IniciaChat
    {
        public async Task startChat()
        {

            AtualizaChat webChat;
            string retornoChat;
            string opcao;
            string mensagem;
            string usuarioDestino;
            var envio = new EnviaMensagem();
            
            Console.WriteLine("Favor digitar seu nome de usuario:");

            var usuario = Console.ReadLine();

            while (1 == 1)
            {
                webChat = new AtualizaChat();

                retornoChat = await webChat.BuscaChat(usuario);

                Console.WriteLine("1- Enviar mensagem publica, 2- Enviar mensagem privada");

                opcao = Console.ReadLine();

                Console.WriteLine("Digitar Mensagem:");

                mensagem = Console.ReadLine();

                if (opcao == "1")
                {
                    envio.Envia(mensagem, usuario, "publico");
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("Para qual usuário deseja enviar a mensagem?");
                    usuarioDestino = Console.ReadLine();
                    envio.Envia(mensagem, usuario, usuarioDestino);
                }
                else
                {
                    Console.WriteLine("Favor digitar opções válidas, 1 ou 2.");
                }

            }

        }
    }
}
