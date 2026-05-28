#region Taks1 
/*
Class 6 Homework 📒
Practice LINQ Vol. 2 🏋️‍♂️
Filter all cars that have origin from Europe.
Find all unique cylinder values for cars.
Select all car names with their model names converted to uppercase.
Check if there are any cars with horsepower greater than 300.
Find the car with the highest horsepower.
Filter all "Chevrolet" cars and order them by weight in descending order.
Find the car with the longest model name.
Group cars by their origin and then order the groups by the number of cars in each group, in ascending order.
Find the first 5 cars with the highest horsepower. (hint: read about LINQ methods Skip() and Take())
Find the car with the highest acceleration time.
Select only the model and horsepower of cars with horsepower greater than 200.
Select all unique origins of cars, ordered alphabetically (ascending).
Select all cars with more than 4 cylinders, and order them by origin and then by horsepower.
Filter all cars that have more than 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result.
Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highest and average Miles per galon for these cars.
Be creative and write requirement of your own choice :) (only one catch, must use at least 3 LINQ methods)
Be creative and write requirement of your own choice :) (only one catch, must use at least 3 LINQ methods)
*/


using Class06.Homework.Models;
using System.Runtime.ConstrainedExecution;

List<Car> cars = CarsData.Cars;


var europeanCars = CarsData.Cars
    .Where(o => o.Origin == "Europe")
    .ToList();


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n╔══════════════════════════════════════╗");
Console.WriteLine("║       Cars from Europe               ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.ResetColor();

foreach (var car in europeanCars)
{
    Console.WriteLine($"{car.Model} - {car.Origin}");
}



var uniqueCylindes = CarsData.Cars
    .Select(unigue => unigue.Cylinders)
    .Distinct()
    .ToList();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n╔══════════════════════════════════════╗");
Console.WriteLine("║       Unique Cylinder Values         ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.ResetColor();

foreach (var car in europeanCars)
{
    Console.WriteLine($"{car.Model} - {car.Cylinders}");
}


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n╔══════════════════════════════════════╗");
Console.WriteLine("║      Car Models with uperCase        ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.ResetColor();


var modelUperCase = CarsData.Cars
    .Select(model => model.Model.ToUpper());


foreach (var carModel in modelUperCase)
{
    Console.WriteLine(carModel);
}



Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n╔══════════════════════════════════════╗");
Console.WriteLine("║      Horsepower greater than 300     ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.ResetColor();


var horsepowerGraterThen300 = CarsData.Cars
    .Where(p => p.HorsePower > 300).ToList();

if (horsepowerGraterThen300.Count == 0)
{
    Console.WriteLine("There is no car with horsepower greater then 300!!");
}

foreach (var car in horsepowerGraterThen300)
{

    Console.WriteLine($"{car.Model} - {car.HorsePower}");
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n╔══════════════════════════════════════╗");
Console.WriteLine("║       Cars with highest horespower   ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.ResetColor();

var highestHorsepowerCar = CarsData.Cars
    .OrderByDescending(p => p.HorsePower)
    .FirstOrDefault();


Console.WriteLine($"Car with highest horsepower: {highestHorsepowerCar?.Model}, HP: {highestHorsepowerCar?.HorsePower}");

var highestHorsepowerCar2 = cars.MaxBy(c => c.HorsePower);

Console.WriteLine($"Car with highest horsepower: {highestHorsepowerCar2?.Model}, HP: {highestHorsepowerCar2?.HorsePower}");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n╔══════════════════════════════════════╗");
Console.WriteLine("║       Chevrolets                     ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.ResetColor();


var chevrolets = CarsData.Cars
    .Where(model => model.Model.Contains("Chevrolet"))
    .OrderByDescending(o => o.Weight)
    .ToList();

foreach (var car in chevrolets)
{
    Console.WriteLine($"{car.Model} - Weight: {car.Weight}");
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n╔══════════════════════════════════════╗");
Console.WriteLine("║  The car with the longest model name ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.ResetColor();

var modelNameLongest = CarsData.Cars
    .MaxBy(x => x.Model.Count());

Console.WriteLine($"The car with the longest model name: {modelNameLongest.Model}");


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n╔══════════════════════════════════════╗");
Console.WriteLine("║  The car with the longest model name ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.ResetColor();

var groupCars = CarsData.Cars
    .GroupBy(o => o.Origin)
    .OrderBy(group => group.Count());

foreach (var group in groupCars)
{
    Console.WriteLine($"Origion: {group.Key}, Count: {group.Count()}");
}










#endregion