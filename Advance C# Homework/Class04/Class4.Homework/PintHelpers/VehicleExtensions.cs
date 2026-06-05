using Class4.Homework.Models;

namespace Class4.Homework.PintHelpers
{
    public static class VehicleExtensions
    {
        public static void Drive(this Car car)
        {
            Console.WriteLine("The car is driving");
        }

        public static void Wheelie(this MotorBike bike)
        {
            Console.WriteLine("The motorbike is driving on one wheel");
        }

        public static void Sail(this Boat boat)
        {
            Console.WriteLine("The boat is sailing");
        }

        public static void Fly(this Airplane plain)
        {
            Console.WriteLine("The airplane is flying");
        }
    }
}
