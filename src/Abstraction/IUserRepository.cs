using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction;

public interface IUserRepository
{
    public IEnumerable<User> FindAll();
    public User CreateOne(User user);
    public User? FindOne(string email);
    public User UpdateOne(User updatedUser);

    public IEnumerable<User>? DeleteOne(string id);
}
