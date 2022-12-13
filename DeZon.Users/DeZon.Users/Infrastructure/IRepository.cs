using DeZon.Users.Entities;

namespace DeZon.Users.Infrastructure;

public interface IRepository
{
    Guid Add(string name);
    IEnumerable<User> GetAll();
}