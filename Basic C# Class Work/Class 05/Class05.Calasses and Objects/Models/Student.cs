namespace Class05.Calasses_and_Objects.Models
{
    internal class Student
    {
        public string FullName { get; set; }

        public int Age { get; set; }

        public Group GroupReference { get; set; }


        public Student(string fullName, int age, Group groupReference)
        {
            FullName = fullName;
            Age = age;
            GroupReference = groupReference;
            
        }


        public void DisplaystudentInfo()
        {
            Console.WriteLine($"{FullName} from group {GroupReference.GroupName}");
        }


    }

        
}
