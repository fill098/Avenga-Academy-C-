


using Class06.LinqMethods.Data;
using Class06.LinqMethods.Entities;
using Class06.LinqMethods.Helpers;

IEnumerable<Student> findBobsLambda = SEDC.Students
    .Where(s => s.FirstName.Equals("Bob", StringComparison.OrdinalIgnoreCase))
    .ToList();

// SQL - like LINQ query syntax

IEnumerable<Student> findBobsQuery = from student in SEDC.Students
                                     where student.FirstName.Equals("Bob", StringComparison.OrdinalIgnoreCase)
                                     select student;

List<string> firstNames = SEDC.Students
    .Select(s => s.FirstName).ToList();

firstNames.PrintSimple();



List<Student> studentPartTimeAndAcademyProgrming = SEDC.Students
    .Where(s => s.IsPartTime && s.Subjects.Any(sub => sub.Type == Academy.Programming))
    .ToList();


Student petko = SEDC.Students.First(s => s.FirstName == "Petko");
Student petko2 = SEDC.Students.FirstOrDefault(s => s.FirstName == "Petko");

Student bob = SEDC.Students.Single(s => s.FirstName == "Bob");
Student bob2 = SEDC.Students.SingleOrDefault(s => s.FirstName == "Bob");

bool hasBOb = SEDC.Students.Any(s => s.FirstName == "Bob");
bool areAllAdults = SEDC.Students.All(s => s.Age >= 18);


List<string> distincStudentsNames = SEDC.Students
    .Select(s => s.FirstName)
    .Distinct()
    .ToList();







