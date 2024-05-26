using System.ComponentModel.DataAnnotations;

namespace sda_onsite_2_csharp_backend_teamwork.src.DTO;

public class UserReadDto
{
    public Guid Id { get; set; }
    public string? FullName { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Role { get; set; }
}
public class UserEditDto
{
    public string? FullName { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Role { get; set; }
}
public class UserCreateDto
{
    [Required]
    public string? FullName { get; set; }
    [Required, EmailAddress]
    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required]
    public string? Phone { get; set; }
}
public class UserSignIn
{
    public string? Email { get; set; }
    public string? Password { get; set; }
}