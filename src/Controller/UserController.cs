using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Service;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller;
public class UserController : BaseController
{
    private IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public IEnumerable<User> FindAll()
    {
        return _userService.FindAll();
    }

    [HttpGet("{UserId}")]
    public ActionResult<User?> FindOne(string userId)
    {
        return Ok(_userService.FindOne(userId));
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<IEnumerable<User>> CreateOne([FromBody] User user)
    {
        if (user is not null)
        {
            var createdUser = _userService.CreateOne(user);
            return CreatedAtAction(nameof(CreateOne), createdUser);
        }
        else return BadRequest();
    }

    [HttpPatch("{UserId}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<User> UpdateOne(string email, User user)
    {
        User? updatedUser = _userService.UpdateOne(email, user);
        if (updatedUser is not null)
        {
            return CreatedAtAction(nameof(UpdateOne), updatedUser);
        }
        else return BadRequest();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult DeleteOne(string id, User user)
    {
        IEnumerable<User>? users = _userService.DeleteOne(id);
        if (users is not null)
        {
            return NoContent();
        }
        else return BadRequest();
    }

}
