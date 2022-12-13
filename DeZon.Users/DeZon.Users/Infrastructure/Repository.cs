using DeZon.Users.Entities;

namespace DeZon.Users.Infrastructure;

public class Repository : IRepository
{
    private static List<User> _users;

    public Repository()
    {
        _users = new List<User>();
    }

    public Guid Add(string name)
    {
        var order = new User(name);

        _users.Add(order);

        return order.Id;
    }

    public IEnumerable<User> GetAll()
    {
        return _users;
    }
}