using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services.Interfaces
{
    public interface IDriverService : IServiceBase<Driver>
    {
        public List<Driver> GetUnassignetDrivers(List<Driver> drivers);
        public void AssignDriverToCar(Driver driver, Car car, Shift shift);
        public List<Driver> GetAssignedDrivers(List<Driver> drivers);
    }
}
