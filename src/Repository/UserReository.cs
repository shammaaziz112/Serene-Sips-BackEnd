using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class UserReository : IUserRepository
{
    private IEnumerable<User> users;
    private List<User> _users;

    public UserReository()
    {
        users = new DatabaseContext().Users;
    }
    public List<User> FindAll()
    {
        return _users;
    }

    public User CreateOne(User user)
    {
        _users.Add(user);
        return user;
    }
    public User? FindOneByEmail(string email)
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
}
