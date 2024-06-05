public class ChatMediator : IMediator
{
    private List<ChatUser> _users;

    public ChatMediator()
    {
        _users = new List<ChatUser>();
    }

    public void RegisterUser(ChatUser user)
    {
        if (!_users.Contains(user))
        {
            _users.Add(user);
            user.SetMediator(this);
        }
    }

    public void SendMessage(string message, ChatUser chatUser)
    {
        foreach (var user in _users)
        {
            // Message should not be received by the user sending it
            var isNotTheSameUser = user != chatUser;
            if (isNotTheSameUser)
            {
                user.Receive(message);
            }
        }
    }
}