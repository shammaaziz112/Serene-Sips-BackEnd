using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class UserRepository : IUserRepository
{
    private IEnumerable<User> _users { get; set; }

    public UserRepository()
    {
        _users = new DatabaseContext().Users;
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
        var users = _users.Select(user =>
         {
             if (user.Email == updatedUser.Email)
             {
                 return updatedUser;
             }
             return user;
         });
        _users = users.ToList();

        return updatedUser;
    }
    public bool DeleteOne(string id)
    {
        User? user = FindOne(id);
        if (user is null) return false;

            var users = _users.Where(user => user.Id != id);
            _users = users;
            return true;
    }
}
