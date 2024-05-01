using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Repository;
using sda_onsite_2_csharp_backend_teamwork.src.Utility;

namespace sda_onsite_2_csharp_backend_teamwork.src.Service;
//Map 
public class UserService : IUserService
{
    private IConfiguration _config;
    public IEnumerable<User> users;
    private IUserRepository _userRepository;
    public UserService( IUserRepository userRepository,IConfiguration config){
       _userRepository =  userRepository;
       _config = config;
    }
    public UserService()
    {
        users = new DatabaseContext().Users;
    }
    public IEnumerable<User> FindAll()
    {
        return _userRepository.FindAll();
    }

    public User? FindOne(string id)
    {
        User? user = users.FirstOrDefault((user) => user.Id == id);
        return user;
    }

    // public User CreateOne(User user)
    // {
    //     users.Append(user);
    //     return user;
    // }

    public User? UpdateOne(string email, User user)
    {
        users.Select(user => user.Id);
        return user;
    }

    public User? DeleteOne(string id, User user)
    {
        users.Where(user => user.Id == id);
        return user;
    }
    public User? CreateOne(User user)
    {
        User? foundUser =
         _userRepository.FindOne(user.Email);
        if (foundUser is not null)
        {
            return null;
        }
        byte[] pepper =
        Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);

        PasswordUtility.HashPassword(user.Password, out string hashedPassword, pepper);
        user.Password = hashedPassword;
        return _userRepository.CreateOne(user);
    }
}
