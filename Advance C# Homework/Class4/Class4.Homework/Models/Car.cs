using Class4.Homework.BaseEntity;

namespace Class4.Homework.Models
{
    public class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I am a car and i have 4 wheels");
        }
    }
}
