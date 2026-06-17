namespace TaxiManagerMyTry.Domain.Models;
using TaxiManagerMyTry.Domain.BaseEntity;
using TaxiManagerMyTry.Domain.Enums;

public class Driver : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public Shift Shift { get; set; }
    public Car? Car { get; set; }
    public string License { get; set; } = string.Empty;
    public DateTime LicenseExpieryDate { get; set; }
}
