using Class3.Polymorphism.Models;

namespace Class3.Polymorphism.Service
{
    public class PetService
    {

        public void PrintPetInfo()
        {
            Console.WriteLine("Some pet info");
        }

        public void PrintPetInfo(Cat cat)
        {
            Console.WriteLine($"This cat is {(cat.IsLazy ? "lazy" : "not lazy")}");            
        }

        //public void PrintPetInfo(Cat petko)
        //{
        //    Console.WriteLine($"This cat is {(cat.IsLazy ? "lazy" : "not lazy")}");
        //}

        public void PrintPetInfo(Dog dog)
        {
            Console.WriteLine($"This cat is {(dog.Isfrindly ? "lazy" : "not lazy")}");
        }

        public void PrintPetInfo(string owner, Dog dog)
        {
            Console.WriteLine($"This owner {owner} has dog name {dog.Name}");

        }
    }
}
