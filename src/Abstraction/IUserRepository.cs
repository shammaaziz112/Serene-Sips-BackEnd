using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction;

public interface IUserRepository
{
    public IEnumerable<User> FindAll();
    public User CreateOne(User user);
    public User? FindOne(Guid id);
    public User UpdateOne(User updatedUser);

    public bool DeleteOne(Guid id);
}
