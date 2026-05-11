#region Run Time Polymophisam


using Class3.Polymorphism.Models;
using Class3.Polymorphism.Service;

Pet randomPet = new Pet
{
    Name = "Mali"
};

randomPet.Eat();

Cat zuza = new Cat
{
    Name = "Zuza",
    IsLazy = true
};

zuza.Eat();



Dog aks = new Dog
{
    Name = "Aks"
};

Dog test = new Dog();

aks.Eat();




#endregion


#region Compile-Time Polymophism
    PetService petService = new PetService();

petService.PrintPetInfo();
petService.PrintPetInfo(aks);
petService.PrintPetInfo(zuza);
petService.PrintPetInfo("Bob", aks);








#endregion


Console.ReadLine();