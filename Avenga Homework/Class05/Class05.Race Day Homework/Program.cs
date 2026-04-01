#region MyRegion


//Make a class Driver. Add properties: Name, Skill
//Make a class Car. Add properties: Model, Speed and Driver
//Make a method of the Car class called : CalculateSpeed() that takes a driver object as input parameter
//and calculates the skill multiplied by the speed of the car and return it as a result.
//Make a method RaceCars() that will get two Car objects that will determine which car will win and print the result in the console.
//Make 4 car objects and 4 driver objects.
//Ask the user to select a two cars and two drivers for the cars.Add the drivers to the cars and call the RaceCars() methods
//Test Data:
//Choose a car no.1:
//Hyundai
//Mazda
//Ferrari
//Porsche
//Choose Driver:
//Bob
//Greg
//Jill
//Anne
//Choose a car no.2:
//Hyundai
//Mazda
//Ferrari
//Porsche
//Choose Driver:
//Bob
//Greg
//Jill
//Anne
//Expected Output:
//Car no. 2 was faster.
//BONUS 1: If a user chooses option one for the first car, eliminate that option when the user picks car two.

//BONUS 2: Make the Output message say what was the model of the car that won, what speed was it going and which driver was driving it.

//BONUS 3: Implement a Race Again Feature where you ask the user if he wants to race again and repeat the racing function.

//You are encouraged to use AI tools such as GitHub Copilot or ChatGPT while working on this homework,
//but make sure you understand every line of code and do not generate the entire solution at once.

using Class05.Race_Day_Homework.Models;

Driver[] drivers = new Driver[]
{
    new Driver { Name = "Bob", Skill = 5 },
    new Driver { Name = "Greg", Skill = 7 },
    new Driver { Name = "Jill", Skill = 6 },
    new Driver { Name = "Anne", Skill = 8 }
};

Car[] cars = new Car[]
{
    new Car { Model = "Hyundai", Speed = 120 },
    new Car { Model = "Mazda", Speed = 130 },
    new Car { Model = "Ferrari", Speed = 200 },
    new Car { Model = "Porsche", Speed = 180 }
};



void RaceUi()
{
    Console.WriteLine("Choose first car number!!");
    for (int i = 0; i < cars.Length; i++)
    {
        Console.WriteLine($"{i + 1}.{cars[i].Model}");

    }
    int carChoose1 = int.Parse(Console.ReadLine()) - 1;


    Console.WriteLine("Choose first Driver!!");
    for (int i = 0; i < drivers.Length; i++)
    {
        Console.WriteLine($"{i + 1}.{drivers[i].Name}");

    }
    int driverChoose1 = int.Parse(Console.ReadLine()) - 1;


    Console.WriteLine("Choose second car number!!");
    for (int i = 0; i < cars.Length; i++)
    {
        Console.WriteLine($"{i + 1}.{cars[i].Model}");

    }
    int carChoose2 = int.Parse(Console.ReadLine()) - 1;


    Console.WriteLine("Choose second driver!!");
    for (int i = 0; i < drivers.Length; i++)
    {
        Console.WriteLine($"{i + 1}.{drivers[i].Name}");

    }
    int driverChoose2 = int.Parse(Console.ReadLine()) - 1;


    cars[carChoose1].Driver = drivers[driverChoose1];
    cars[carChoose2].Driver = drivers[driverChoose2];

    Car.RaceCars(cars[carChoose1], cars[carChoose2]);



}

RaceUi();



#endregion
