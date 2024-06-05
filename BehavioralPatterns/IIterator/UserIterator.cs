public class UserIterator : IIterator
{
    private List<User> _users;
    private int _position = 0;

    public UserIterator(List<User> users)
    {
        _users = users;
    }

    public bool HasNext()
    {
        return _position < _users.Count;
    }

    public User Next()
    {
        return _users[_position++];
    }
}