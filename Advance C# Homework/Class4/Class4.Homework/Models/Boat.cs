using Class4.Homework.BaseEntity;

namespace Class4.Homework.Models
{
    public class Boat : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I am a boat and i do not have any wheels!!");
        }
    }
}
