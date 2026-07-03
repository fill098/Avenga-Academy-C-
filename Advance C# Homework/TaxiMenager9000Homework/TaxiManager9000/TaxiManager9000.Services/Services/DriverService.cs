using System.Runtime.ConstrainedExecution;
using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Helpers;
using TaxiManager9000.Services.Interfaces;

namespace TaxiManager9000.Services.Services
{
    public class DriverService : ServiceBase<Driver>, IDriverService
    {
       

        public List<Driver> GetUnassignetDrivers(List<Driver> drivers)
        {
            return drivers.Where(x => x.Car == null).ToList();
        }
        public void AssignDriverToCar(Driver driver, Car car, Shift shift)
        {
            driver.Shift = shift;
            driver.Car = car;
            car.AssignedDrivers.Add(driver);
        }

        public List<Driver> GetAssignedDrivers(List<Driver> drivers)
        {
            return drivers.Where(x => x.Car != null).ToList();
        }
        public void UnassignDriverFromCar(Driver driver)
        {
            Car car = driver.Car;
            car.AssignedDrivers.Remove(driver);

            driver.Car = null;
            driver.Shift = Shift.NoShift;
        }

    }
}
