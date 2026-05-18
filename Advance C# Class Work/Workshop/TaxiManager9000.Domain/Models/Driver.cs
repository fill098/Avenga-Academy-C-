namespace TaxiManager9000.Domain.Models;

public enum Shift
{
    Morning,
    Afternoon,
    Evening
}

public class Driver
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public Shift Shift { get; set; }
    public Car? Car { get; set; }
    public string License { get; set; } = string.Empty;
    public DateTime LicenseExpieryDate { get; set; }
}
