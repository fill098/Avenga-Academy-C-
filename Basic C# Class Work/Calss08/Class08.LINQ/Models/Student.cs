namespace Class08.LINQ.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FistName { get; set; }

        public string LastName { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public Academy Academy { get; set; }
        public List<string> Subjects { get; set; }

        public Student(int id, string fname, string lname,int age,string group, Academy academy, List<string> subjects)
        {
            Id = id;
            FistName = fname;
            LastName = lname;
            Age = age;
            Group = group;
            Academy = academy;
            Subjects = subjects ?? new List<string>();
                
        }
    }
}
