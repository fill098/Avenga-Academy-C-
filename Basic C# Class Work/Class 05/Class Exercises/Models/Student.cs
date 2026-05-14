namespace Class_Exercises.Models
{
    internal class Student
    {
        public string Name { get; set; }

        public string Academy { get; set; }

        public string Group { get; set; }

        public Student(string name, string academy, string group)
        {
            
            Name = name;
            Academy = academy;
            Group = group;
        }
    }
}
