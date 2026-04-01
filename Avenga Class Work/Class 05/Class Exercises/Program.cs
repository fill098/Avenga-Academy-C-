using Class_Exercises.Models;
using System.Xml.Linq;



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




Console.WriteLine("Enter first name for human");
string firstName = Console.ReadLine() ?? "Unknown";
Console.WriteLine("Enter surname for human");
string lastName = Console.ReadLine() ?? "Unknown";
Console.WriteLine("Enter age name for human");
string ageHuman = Console.ReadLine() ?? "0";





Human human1 = new Human
{
    Name = firstName,
    Surname = lastName,
    Age = ageHuman
};


Console.WriteLine(human1.Name);
Console.WriteLine(human1.Surname);
Console.WriteLine(human1.Age);
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


<<<<<<< HEAD
=======
Console.WriteLine("Enter the dogs name!!");
string dogName = Console.ReadLine() ?? "Unknown";
Console.WriteLine("Enetr the dogs race!!");
string dogRace = Console.ReadLine() ?? "Unknown";
Console.WriteLine("Enter the dogs color!!");
string dogColor = Console.ReadLine() ?? "Unknown";





Dog pitbull = new Dog(dogName, dogRace, dogColor);


Console.WriteLine("Enter 1 - Eat, 2 - Play, 3 - ChasingTail ");

string dogAction = Console.ReadLine();

if (dogAction == "1")
{
    pitbull.Eat();

}
else if (dogAction == "2")
{
    pitbull.Play();
}
else if (dogAction == "3")
{
    pitbull.ChaseTail();
}
else
{
    Console.WriteLine("Unknown comand. Please enter 1, 2 or 3!!");
}





#endregion

#region EXERCISE 3
//Create a class Student with properties:

//Name
//Academy
//Group
//Create an array with 5 Student objects.

//Ask the user to enter a name:

//If the student exists → print the information
//If not → print an error message


Student[] students = new Student[]
{
    new Student ("Filip", "Avenga", "G1"),
    new Student ("Tomi", "Avenga", "G2"),
    new Student ("Damjan", "Avenga", "G3"),
    new Student ("Igor", "Network Acadmey", "G3"),
    new Student ("Igor", "Network Acadmey", "G3")
};

Console.WriteLine("Enter a name to be searched in thee data base!!");

string searchInput = Console.ReadLine().ToLower();

foreach (Student student in students)
{
    if (student.Name.ToLower() == searchInput)
    {
        Console.WriteLine($"Student found with name: {student.Name} group: {student.Group} acadmey: {student.Academy}");
        
       
    }
}

Console.WriteLine("No student was found please try again with difrent name!!");


>>>>>>> 0341d2eff48d04df8bf4da16e80a7fda3aa5311b

#endregion
