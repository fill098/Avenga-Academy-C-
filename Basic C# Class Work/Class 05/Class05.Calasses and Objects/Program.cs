using Class05.Calasses_and_Objects.Models;


#region Casses definition and creating instance objects


Person filip = new Person();
filip.FirstName = "FIlip";
filip.LastName = "MIhajlovski";
filip.PhoneNumber = "072/000/234";
filip.Hobbies = ["Gym", "Coking", "Frends"];
filip.Age = 27;
filip.IsStudent = true;


Console.WriteLine($"The valus for {filip.FirstName} {filip.LastName} and his is {filip.Age} years old and my social security number is {filip.GetSSNValue()}!!");

filip.Talk();

Console.ReadLine();

Person martin = new Person()
{
    FirstName = "Martin",
    LastName = "Mihajlovski",
    PhoneNumber = "610033432",
    Hobbies = ["Gym", "Work", "Going out"],
    Age = 36,
    IsStudent = false
};

Console.WriteLine($"The valus for {martin.FirstName} {martin.LastName} and his is {martin.Age} years old and my socila security number is {martin.GetSSNValue()}!!");
martin.Talk();


Console.ReadLine();

Person milena = new Person("Milena", "Dimitrievska", "26452836", 44, ["Traveling", "Shoping"], false);

Console.WriteLine($"The valus for {milena.FirstName} {milena.LastName} and his is {milena.Age} years old and my social security number is {milena.GetSSNValue()}!!");

milena.Talk();







#endregion

#region Woorkinig with Classes instace Objects 

Group g1 = new Group("G1", 12, "C# Basic");
Group g2 = new Group("G2", 8, "Basic NodeJs");


Student mario = new Student("Mario Simonoscki", 34, g1);
Student dimitar = new Student("Dimitar Kocevski", 19, g1);

Student tomi = new Student("Tomi Tomi", 28, g2);

Student ivo = new Student("Ivo KOstovski", 36, new Group("G3", 10, "HTML/CSS"));

Student cvetko = new Student("Cvetko Cevetkovski", 25, new Group 
{ 
    GroupName = "G3",
    NumOfStudents = 15,
    CurrentSubjctName = "HTML/CSS"

});



Console.ReadLine();


mario.DisplaystudentInfo();

dimitar.DisplaystudentInfo();
tomi.DisplaystudentInfo();

mario.GroupReference.DisplayGroupInfo();







#endregion
