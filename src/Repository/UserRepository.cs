using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class UserRepository : IUserRepository
{
    public IEnumerable<User> Users;

    public UserRepository()
    {
        Users = new DatabaseContext().Users;
    }
    public IEnumerable<User> FindAll()
    {
        return Users;
    }

    public User CreateOne(User user)
    {
        Users.Append(user);
        return user;
    }
    public User? FindOne(string email)
    {
        User? user = Users.FirstOrDefault(user => user.Email == email);
        return user;
    }

    public User UpdateOne(User updatedUser)
    {
        var users = Users.Select(user =>
         {
             if (user.Email == updatedUser.Email)
             {
                 return updatedUser;
             }
             return user;
         });
        Users = users.ToList();

        return updatedUser;
    }
    public IEnumerable<User>? DeleteOne(string id)
    {
        User? user = FindOne(id);
        if (user is not null)
        {
            var users = Users.Where(user => user.Id != id);
            Users = users;
            return Users;
        }
        return null;
    }
}
