namespace Class3.Polymorphism.Models
{
    public class Dog : Pet
    {

        public bool  Isfrindly { get; set; }

        public override void Eat()
        {
            Console.WriteLine($"The {(Isfrindly ? "friendly" : "")} cat {Name} is eating....");

        }
    }
}
