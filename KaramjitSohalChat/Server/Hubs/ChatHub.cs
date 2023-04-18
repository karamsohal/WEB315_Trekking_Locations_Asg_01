using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace KaramjitSohalChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

         public async Task SendTyping(string user)
        {
            await Clients.Others.SendAsync("UserTyping", user);
        }

         public async Task SendAnon(string message)
        {
            await Clients.All.SendAsync("ReceiveAnonMessage", message);
        }
    }
}