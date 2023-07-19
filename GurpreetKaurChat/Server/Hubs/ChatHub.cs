using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System;

namespace GurpreetKaurChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public async Task SendTypingNotification()
        {
            await Clients.Others.SendAsync("UserTyping", Context.ConnectionId);
        }

        public async Task SendAnonymousMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveAnonMessage", message);
        }
    }
}