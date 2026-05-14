using Class03.Homework.BaseEntity;

namespace Class03.Homework.Models2
{
    public class Boat : Vehicle
    {
        public override void DispalyInfo()
        {
            Console.WriteLine("I am a boat and i dont have any wheels!!");
        }
    }
}
