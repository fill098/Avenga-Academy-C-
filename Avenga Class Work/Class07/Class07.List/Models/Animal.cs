

namespace Class07.Inheritance
{
    public class Animal
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public Animal()
        {
            Console.WriteLine("A new istance of an Animal has ben created!!. This is the Animal empty costructor.");
            Thread.Sleep(2000);
        }

        public Animal(string type)
        {
            
            Type = type;
            Console.WriteLine("This is the type costructor of an Animal!!");
            Thread.Sleep(2000);
        }

        public Animal(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
            
        }

        public virtual void Eat()
        {
            Console.WriteLine($"The {Type} animal named {Name} is eating!!!");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}, Animal: {Type},  Name:{Name}!!!");
        }

        
    }
}
