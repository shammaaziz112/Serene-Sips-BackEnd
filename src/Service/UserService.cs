using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Service;
//Map 
public class UserService : IUserService
{
    public IEnumerable<User> users;
    public UserService()
    {
        users = new DatabaseContext().Users;
    }
    public IEnumerable<User> FindAll()
    {
        return users;
    }

    public User? FindOne(string id)
    {
        User? user = users.FirstOrDefault((user) => user.Id == id);
        return user;
    }
   
    public User CreateOne( User user)
    {
        users.Append(user);
        return user;
    }

    public User? UpdateOne(string email, User user)
    {
        users.Select(user => user.Id);
        return user;
    }

    public User? DeleteOne(string id,User user)
    {
        users.Where(user => user.Id == id);
        return user;
    }

}
