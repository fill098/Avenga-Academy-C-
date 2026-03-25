namespace Class_05.Classes_and_Objects.Models
{
    internal class Student
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public Grope Group { get; set; }

        public Student(string fullName, int age, Grope group)
        {
            FullName = fullName;
            Age = age;

            Group = group ?? new Grope("Unknow", 0, "Unknow");
            //if (group != null)
            //{
            //    Group = group;
            //}
            //else
            //{
            //    Group = new Grope("Unknow", 0, "Unknow");
            //}
            

        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"{FullName} from group {Group.GroupNAme}");
        }
    }
}
