using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller;

[ApiController]
[Route("api/v1/[controller]")]
public class TestController : ControllerBase
{
    private List<User> _users;
    public TestController()
    {
        _users = new DatabaseContext().Users;
    }
    [HttpGet]
    public List<User> FindAll()
    {
        return _users;
    }
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

}
