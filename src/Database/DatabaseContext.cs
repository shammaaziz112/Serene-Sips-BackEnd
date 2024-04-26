
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Database;
public class DatabaseContext
{
    public List<User> Users;

    public DatabaseContext()
    {
        Users = [
            new User("1","Raghad","1111"),
            new User("2","Shama","2222"),
            new User("3","Omnia","3333"),
            new User("4","Sara","4444"),
        ];
    }
}



