namespace Class08.ASP.NET.MVC.EntityframeWorkCORE.Models.Domain
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int ActiveCourseId { get; set; }

        public Course ActiveCourse { get; set; }
    }
}
