namespace DeZon.Users.Entities;

public class User
{
    private User()
    {
        Id = Guid.NewGuid();
    }
    
    public User(string name) : this()
    {
        Name = name;
    }

    public Guid Id { get; private set; }

    public string Name { get; private set; }
}