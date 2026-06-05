using Claaa11.AddNet_Demo.DataAccess;
using Claaa11.AddNet_Demo.Models;

Console.WriteLine("Hello, World!");
const string ConnectionString = "Server=.\\SQLEXPRESS;Database=SEDC_DEMO_SHARP;Integrated Security=True;Encrypt=False";

StudentRepository studentRepository = new StudentRepository(ConnectionString);



List<Student> allStudents =  studentRepository.GetAllStudents();

foreach (var student in allStudents)
{
    Console.WriteLine(student);
}


Console.ReadLine();