#region EXERCISE 1
//Create a class Human.

//Add properties:

//FirstName
//LastName
//Age
//Create a method GetPersonStats that:

//Returns the full name
//Returns the age
//Ask the user for input, create an object and print the result in the console.


using Class_Exercises;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

Console.WriteLine("Enter first name for human");
 string firstName = Console.ReadLine();
Console.WriteLine("Enter first name for human");
string lastName = Console.ReadLine();
Console.WriteLine("Enter age name for human");
string ageHuman = Console.ReadLine();



Human human1 = new Human
{
    Name = firstName,
    Surname = lastName,
    Age = ageHuman
};

Console.WriteLine(human1.FullName());




#endregion

#region EXERCISE 2

//Create a class Dog.

//Add properties:

//Name
//Race
//Color
//Add methods:

//Eat → prints “The dog is now eating.”
//Play → prints “The dog is now playing.”
//ChaseTail → prints “The dog is now chasing its tail.”
//Ask the user to:

//Enter dog data
//Choose one of the actions
//Call the selected method.
#endregion
