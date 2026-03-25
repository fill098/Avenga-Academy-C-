namespace Class_05.Classes_and_Objects.Models
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string[] Hobbise { get; set; }
        public bool IsStudent { get; set; }
        private long SSN { get; set; }

        // Default costructor and is parapetarless
        public Person()
        {
            SSN = GenerateSSN();

        }

        public Person(string fname, string lname , string phoneNuber, int age, string[] hobbeis, bool isStudent)
        {

            FirstName = fname;
            LastName = lname;
            PhoneNumber = phoneNuber;
            Age = age;
            Hobbise = hobbeis;
            IsStudent = isStudent;
            SSN = GenerateSSN();
                
        }

        private long GenerateSSN()
        {
            return new Random().Next(100000, 999999);
        }

        public void Talk(string text)
        {
            Console.WriteLine($"The human name {FirstName} (SSN: {SSN}) is saying {text}");

        }

        public long GetSSNvalue()
        {
            return SSN;
        }


       





    }
}
