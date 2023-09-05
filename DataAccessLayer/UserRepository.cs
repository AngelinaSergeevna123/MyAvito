using DataAccessLayer.Entities;

namespace DataAccessLayer;

public class UserRepository
{
    private readonly List<User> _users = new();
    
    public void AddUser(string name, string password) => _users.Add(new(name, password));
}