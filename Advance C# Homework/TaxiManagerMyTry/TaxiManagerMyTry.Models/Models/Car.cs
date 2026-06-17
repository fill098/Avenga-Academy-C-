namespace TaxiManagerMyTry.Domain.Models;

using TaxiManagerMyTry.Domain.BaseEntity;
public class Car : BaseEntity
{
    public string Model { get; set; } = string.Empty;
    public string LicensePlate { get; set; } = string.Empty;
    public DateTime LicensePlateExpieryDate { get; set; }
    public List<Driver> AssignedDrivers { get; set; } = new();
}

