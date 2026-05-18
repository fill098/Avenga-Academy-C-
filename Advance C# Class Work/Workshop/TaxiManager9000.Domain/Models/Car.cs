namespace TaxiManager9000.Domain.Models;

public class Car
{
    public int Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public string LicensePlate { get; set; } = string.Empty;
    public DateTime LicensePlateExpieryDate { get; set; }
    public List<Driver> AsignedDrivers { get; set; } = new();
}
