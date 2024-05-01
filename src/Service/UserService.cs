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
    private IUserRepository _userRepository;
    public UserService(IUserRepository userRepository, IConfiguration config)
    {
        _userRepository = userRepository;
        _config = config;
    }
    public IEnumerable<User> FindAll()
    {
        return _userRepository.FindAll();
    }

    public User? FindOne(string id)
    {
        return _userRepository.FindOne(id);
    }
    public User? UpdateOne(string email, User user)
    {
        User? updatedUser = _userRepository.FindOne(email);
        if (updatedUser is not null)
        {
            updatedUser.FullName = user.FullName;
            updatedUser.Phone = user.Phone;
            return _userRepository.UpdateOne(updatedUser);
        }
        else return null;
    }

    public IEnumerable<User>? DeleteOne(string id)
    {
        return _userRepository.DeleteOne(id);
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
