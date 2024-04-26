namespace sda_onsite_2_csharp_backend_teamwork.src.Entity;
public class User
{
    public User(string id, string name, string password)
    {
        Id = id;
        Name = name;
        Password = password;
    }
    public string Id {get;set;}
     public string Name {get;set;}
      public string Password {get;set;}
}
