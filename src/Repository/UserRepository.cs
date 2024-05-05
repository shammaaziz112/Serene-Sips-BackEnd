using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class UserRepository : IUserRepository
{
    private DbSet<User> _users { get; set; }
    private DatabaseContext _databaseContext;

    public UserRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
        _users = databaseContext.Users;
    }
    public IEnumerable<User> FindAll()
    {
        return _users;
    }

    public User CreateOne(User user)
    {
        _users.Append(user);
        return user;
    }
    public User? FindOne(string email)
    {
        User? user = _users.FirstOrDefault(user => user.Email == email);
        return user;
    }

    public User UpdateOne(User updatedUser)
    {
        _users.Update(updatedUser);
        return updatedUser;
    }
    public bool DeleteOne(string id)
    {
        User? user = FindOne(id);
        if (user is null) return false;
        _users.Remove(user);
        return true;
    }
}
