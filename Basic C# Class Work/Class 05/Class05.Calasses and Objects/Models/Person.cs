namespace Class05.Calasses_and_Objects.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string[] Hobbies { get; set; }
        public bool IsStudent { get; set; }

        private long SSN { get; set; }

        public Person()
        {
            SSN = GenerateSSN();
        }

        public Person(string fName, string lName, string phoneNumber, int age, string[] hobbies, bool isStudent)
        {
            FirstName = fName;
            LastName = lName;
            PhoneNumber = phoneNumber;
            Age = age;
            Hobbies = hobbies;
            IsStudent = isStudent;
            SSN = GenerateSSN();
        }


        public void Talk()
        {
            Console.WriteLine($"The person {FirstName} {LastName} is saing I am {Age} years old and my phone number is: {PhoneNumber}");
        }

        private long GenerateSSN()
        {
            return new Random().Next(1000, 5000);
        }


        public long GetSSNValue()
        {
            return SSN;
        }





    }
}
