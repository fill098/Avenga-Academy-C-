using Class07.Inheritance;
using Class07.Inheritance.Models;


Animal elephant = new Animal() { Id = 1, Name = "Dambo", Type = "Elephant" };

elephant.PrintInfo();
elephant.Eat();
Console.WriteLine("-------------------------------------------------");

Dog dog = new Dog() { Id = 2, Name = "Spiky", Type = "Dog", Race = "Labrador" };

dog.PrintInfo();
dog.Eat();
dog.Bark();

Cat cat = new Cat() { Id = 3, Name = "Garfild", Lazyness="Very"};

Console.WriteLine("-------------------------------------------------");

cat.PrintInfo();
cat.Eat();
cat.Meow();

Perrot riki = new Perrot(4, "Riki", "Parrot", "Red");

Console.WriteLine("-------------------------------------------------");
riki.PrintInfo();
riki.Eat();
riki.Fly();


Perrot miki = new Perrot()
{
    Id = 4,
    Name = "MIki",
    Type = "Parrot",
    Color = "Yellow"
};
Console.WriteLine("-------------------------------------------------");
miki.PrintInfo();
miki.Eat();
miki.Fly();


