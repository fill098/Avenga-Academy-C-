using Class_05.Classes_and_Objects.Models;


#region Classes deffinition and creating instant objects





// Create a Person object usining the parametar constructor and set propertis manually




Person martin = new Person();


martin.FirstName = "Filip";
martin.LastName = "mihajlovski";
martin.Age = 27;

martin.Hobbise = ["Readinig books", "Rummimg"];
martin.IsStudent = false;


Console.WriteLine($"{martin.FirstName} {martin.LastName} - {martin.GetSSNvalue()}");

Console.ReadLine();

//Create a Person object usinig the object initialazer syintax

Person bob = new Person()
{
    FirstName = "Bob",
    LastName = "Bobsky",
    Age = 25,
    PhoneNumber = "072/222-333",
    Hobbise = ["Runinig", "Losteninig to music"],
    IsStudent = true
};

Console.WriteLine($"{bob.FirstName} {bob.LastName} - {bob.GetSSNvalue()} is {bob.Age} years old.");

Console.ReadLine();


Person jill = new Person("Jill", "Wayne", "070/123-456", 28, [], true);

Console.WriteLine($"{jill.FirstName} {jill.LastName} - {jill.GetSSNvalue()} is {jill.Age} years old.");


jill.Talk("Hello there nice to mert you!!");

















#endregion

#region Working with Classes

Grope g1 = new Grope("G1", 12, "BasicC#");
Grope g2 = new Grope("G2", 12, "Web development usng NodeJs");

Student mario = new Student("mario", 34, g1);
Student dimitar = new Student("dimitar", 19, g1);
Student tomi = new Student("Tomi Tomi", 32, g2);

Student ivo = new Student("Ivo Kostovski", 36, new Grope("G3", 10, "HTML/CSS"));

Student cvetko = new Student("Cvetko Cvetkoski", 35, new Grope()
{
    GroupNAme = "G3",
    NUmberOfStudents = 10,
    CurentSubjectName = "HTML/CSS"
});


mario.DisplayStudentInfo();
dimitar.DisplayStudentInfo();
tomi.DisplayStudentInfo();
ivo.DisplayStudentInfo();
cvetko.DisplayStudentInfo();


Student filip = new Student("Filip MIhajlovski", 27, null);
filip.DisplayStudentInfo();


#endregion
