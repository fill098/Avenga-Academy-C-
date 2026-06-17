namespace TaxiManagerMyTry.Domain.Models;

using TaxiManagerMyTry.Domain.BaseEntity;
using TaxiManagerMyTry.Domain.Enums;

public class User : BaseEntity
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public Role Role { get; set; }
}
