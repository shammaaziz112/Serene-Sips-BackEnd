using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction;

public interface IUserService
{
    public IEnumerable<User> FindAll();
    public User? FindOne(string id);
    public User CreateOne(User user);
    public User? UpdateOne(string email, User user);
    public User? DeleteOne(string id, User user);

}
