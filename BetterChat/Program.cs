using BetterChat.Data;
using BetterChat.Hubs;

namespace BetterChat
{
    public class Program
    {
        //uwu haha xD 
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IMessageRepo, MessageRepo>();
            builder.Services.AddSignalR();
            
            var app = builder.Build();

            app.MapGet("/", () => "Server is running!");
            app.MapHub<ChatHub>("/chat");
            app.Run();
        }
    }
}