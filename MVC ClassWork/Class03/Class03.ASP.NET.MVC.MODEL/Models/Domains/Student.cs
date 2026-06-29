namespace Class03.ASP.NET.MVC.MODEL.Models.Domains
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Course ActiveCourse { get; set; }

    }
}
