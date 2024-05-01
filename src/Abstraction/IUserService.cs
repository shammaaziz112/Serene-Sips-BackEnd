using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction;

public interface IUserService
{
    public IEnumerable<UserReadDto> FindAll();
     public UserReadDto? FindOne(string id);
    public UserReadDto? CreateOne(User user);
    public UserReadDto? UpdateOne(string email, User user);
    public bool DeleteOne(string id);
}
