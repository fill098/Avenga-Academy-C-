using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Interfaces;

namespace TaxiManager9000.Services.Services
{
    public class CarService : ServiceBase<Car>, ICarService
    {
        public double GetShiftCoveragePercentage(Car car)
        {
            const int totalShifts = 3;

            int coveredShifts = car.AssignedDrivers
                .Select(d => d.Shift)
                .Distinct()
                .Count(s => s != Shift.NoShift);

            return (double)coveredShifts / totalShifts * 100;
        }
        public LicenseStatus GetLicenseStatus(Car car)
        {
            TimeSpan timeUntilExpiry = car.LicensePlateExpieryDate - DateTime.Now;

            if (timeUntilExpiry < TimeSpan.Zero)
                return LicenseStatus.Expired;

            if (timeUntilExpiry <= TimeSpan.FromDays(90))
                return LicenseStatus.ExpiringSoon;

            return LicenseStatus.Valid;
        }

        public List<Car> GetAvailableCarsForShift(List<Car> cars, Shift shift)
        {
            return cars.Where(car =>
                GetLicenseStatus(car) != LicenseStatus.Expired &&
                !car.AssignedDrivers.Any(d => d.Shift == shift)
            ).ToList();
        }

        
    }
}
