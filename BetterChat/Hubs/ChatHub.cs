using BetterChat.Data;
using BetterChat.Models;
using Microsoft.AspNetCore.SignalR;

namespace BetterChat.Hubs
{
    public class ChatHub : Hub
    {
        public ChatHub(IMessageRepo messageRepo)
        {
            MessageRepo = messageRepo;
        }
        public IMessageRepo MessageRepo { get; }
        public Logger<ChatHub> Logger { get; }

        public async Task SendMessage(Message message)
        {
            MessageRepo.AddMessage(message);
            Console.WriteLine($"got message: {message.Text} from: {message.Sender}");
            await Clients.Others.SendAsync("ReceiveMessage", message);
        }
    }
}
