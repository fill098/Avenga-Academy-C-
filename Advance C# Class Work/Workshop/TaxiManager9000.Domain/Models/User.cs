namespace TaxiManager9000.Domain.Models;

public enum UserRole
{
    Administrator,
    Manager,
    Maintenance
}

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public UserRole Role { get; set; }
}
