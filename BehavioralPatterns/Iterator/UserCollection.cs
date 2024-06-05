public class UserCollection : ICollection
{
    private List<User> _users = new List<User>();

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public IIterator CreateIterator()
    {
        return new UserIterator(_users);
    }
}