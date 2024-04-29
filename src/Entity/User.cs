namespace sda_onsite_2_csharp_backend_teamwork.src.Entity;
public class User
{
    public User(string id, string fullname, string password, string phone, string email, string role)
    {
        Id = id;
        FullName = fullname;
        Password = password;
        Phone = phone;
        Email = email;
        Role = role;
    }
    public string Id { get; set; }
    public string FullName { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
}
