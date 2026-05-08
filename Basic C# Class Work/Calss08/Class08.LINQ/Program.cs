#region LINQ EXERCISE

using Class08.LINQ.Models;
using System.Diagnostics;

List<Student> students = new List<Student>
{
    new Student(1,  "Alice",  "Johnson",  20, "G1", Academy.WebDev,   new List<string> { "HTML", "CSS", "JavaScript" }),
    new Student(2,  "Bob",    "Smith",    22, "G2", Academy.Frontend,  new List<string> { "React", "TypeScript", "CSS" }),
    new Student(3,  "Clara",  "Davis",    19, "G3", Academy.Desin,     new List<string> { "Figma", "Photoshop", "Illustrator" }),
    new Student(4,  "Daniel", "Brown",    24, "G1", Academy.Desin,     new List<string> { "Figma", "UX Research", "Wireframing" }),
    new Student(5,  "Emma",   "Wilson",   21, "G2", Academy.WebDev,    new List<string> { "C#", "ASP.NET", "SQL" }),
    new Student(6,  "Frank",  "Miller",   23, "G3", Academy.Frontend,  new List<string> { "Vue.js", "JavaScript", "SASS" }),
    new Student(7,  "Grace",  "Taylor",   20, "G1", Academy.Frontend,  new List<string> { "Angular", "TypeScript", "RxJS" }),
    new Student(8,  "Henry",  "Anderson", 25, "G2", Academy.WebDev,    new List<string> { "Node.js", "MongoDB", "Express" }),
    new Student(9,  "Isla",   "Thomas",   22, "G3", Academy.Desin,     new List<string> { "Adobe XD", "Prototyping", "Branding" }),
    new Student(10, "James",  "Jackson",  21, "G1", Academy.WebDev,    new List<string> { "HTML", "PHP", "MySQL" })
};


Student lisa = students
    .Where(x => x.FistName == "Emma")
    .First();

Console.WriteLine($"{lisa.FistName} {lisa.LastName} - {lisa.Academy.ToString()}");

var allWebDevStudentsFromG1 = students
    .Where(x => x.Academy == Academy.WebDev && x.Group == "G1")
    .ToList();

foreach (var std in allWebDevStudentsFromG1)
{
    Console.WriteLine($"{std.FistName} {std.LastName} - Academy: {std.Academy.ToString()} Group: {std.Group}");

}

var lastStudent = students.Last();

Console.WriteLine($"{lastStudent.FistName} {lastStudent.LastName}");


var franksSubjcts = students
    .Where(x => x.FistName == "Frank")
    .Select(x => x.Subjects)
    .First();


foreach(var sub in franksSubjcts)
{
    Console.WriteLine(sub);
}


var costumSelection = students.Where(x => x.FistName == "Grace").Select(x => new
{
    FullName = $"{x.FistName} {x.LastName}",
    Subjects = x.Subjects

}).FirstOrDefault();

Console.WriteLine(costumSelection.FullName);

foreach(var sub in costumSelection.Subjects)
{
    Console.WriteLine(sub);
}


#endregion