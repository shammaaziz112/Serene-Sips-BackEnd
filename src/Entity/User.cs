namespace sda_onsite_2_csharp_backend_teamwork.src.Entity;
public class User
{
    public string Id { get; set; }
    public string FullName { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public User(string id, string fullName, string password, string phone, string email, string role)
    {
        Id = id;
        FullName = fullName;
        Password = password;
        Phone = phone;
        Email = email;
        Role = role;
    }
}
