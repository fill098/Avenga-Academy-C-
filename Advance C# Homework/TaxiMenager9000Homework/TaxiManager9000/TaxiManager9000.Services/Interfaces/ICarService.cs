using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services.Interfaces
{
    public interface ICarService : IServiceBase<Car>
    {
        public double GetShiftCoveragePercentage(Car car);
        public LicenseStatus GetLicenseStatus(Car car);
        public List<Car> GetAvailableCarsForShift(List<Car> cars, Shift shift);
    }
}
