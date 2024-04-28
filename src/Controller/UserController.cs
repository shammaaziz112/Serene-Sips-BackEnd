using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller;
public class UserController : BaseController
{
    private List<User> _users;
    public UserController()
    {
        _users = new DatabaseContext().Users;
    }
    [HttpGet]
    public List<User> FindAll()
    {
        return _users;
    }
    [HttpGet("{id}")]
    public User? FindOne(string id)
    {
        User? user = _users.FirstOrDefault((user) => user.Id == id);
        return user;
    }
    [HttpPost]
    public List<User> CreateOne([FromBody] User user)
    {
        _users.Add(user);
        return _users;
    }
    [HttpPatch]
    public User? UpdateOne(string email, User user)
    {
        _users.Select(user => user.Id);
        return user;
    }
    [HttpDelete]
    public User? DeleteOne(string id,User user)
    {
        _users.Where(user => user.Id == id);
        return user;
    }

}
