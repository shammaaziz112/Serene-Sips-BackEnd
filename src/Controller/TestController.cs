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
}
