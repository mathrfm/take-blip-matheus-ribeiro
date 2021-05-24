using System;
using System.Threading.Tasks;

namespace WebChatClient
{
    class Program
    {
        
        static async Task Main(string[] args)
        {
            IniciaChat chat = new IniciaChat();

            await chat.startChat();
        }
        
    }
}
