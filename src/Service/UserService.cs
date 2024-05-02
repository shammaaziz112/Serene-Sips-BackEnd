using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Repository;
using sda_onsite_2_csharp_backend_teamwork.src.Utility;

namespace sda_onsite_2_csharp_backend_teamwork.src.Service;
//Map 
public class UserService : IUserService
{
    private IConfiguration _config;
    private IUserRepository _userRepository;
    private IMapper _mapper;
    public UserService(IUserRepository userRepository, IConfiguration config, IMapper mapper)
    {
        _userRepository = userRepository;
        _config = config;
        _mapper = mapper;
    }
    public IEnumerable<UserReadDto> FindAll()
    {
        var user = _userRepository.FindAll();
        var userRead = user.Select(_mapper.Map<UserReadDto>);
        return userRead; 
    }

    public UserReadDto? FindOne(string id)
    {
        User? user = _userRepository.FindOne(id);
        UserReadDto? userRead = _mapper.Map<UserReadDto>(user);
        return userRead;
    }
    public UserReadDto? UpdateOne(string email, User user)
    {

        User? updatedUser = _userRepository.FindOne(email);
        if (updatedUser is not null)
        {
            updatedUser.FullName = user.FullName;
            updatedUser.Phone = user.Phone;
            var userAllInfo = _userRepository.UpdateOne(updatedUser);
            var userRead = _mapper.Map<UserReadDto>(userAllInfo);
            return userRead;
        }
        else return null;
    }

    public bool DeleteOne(string id)
    {
        return _userRepository.DeleteOne(id);
    }

    public UserReadDto? CreateOne(User user)
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


        var createdUser = _userRepository.CreateOne(user);
        var userRead = _mapper.Map<UserReadDto>(createdUser);
        return userRead;
    }
}
