public interface IMediator
{
    void SendMessage(string message, ChatUser user);
    void RegisterUser(ChatUser user);
}