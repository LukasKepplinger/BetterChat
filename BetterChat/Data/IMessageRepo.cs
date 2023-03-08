using BetterChat.Models;

namespace BetterChat.Data
{
    public interface IMessageRepo
    {
        void AddMessage(Message message);
        List<Message> GetMessages();
    }
}
