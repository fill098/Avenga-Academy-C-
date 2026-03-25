namespace Class_05.Classes_and_Objects.Models
{
    internal class Grope
    {

        public string GroupNAme { get; set; }
        public int NUmberOfStudents { get; set; }

        public string CurentSubjectName { get; set; }

        public Grope()
        {

        }
        public Grope (string goupeName, int numOfStudents, string currentSubjectName )
        {
            GroupNAme = goupeName;
            NUmberOfStudents = numOfStudents;
            CurentSubjectName = currentSubjectName;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"This is a {GroupNAme} with {NUmberOfStudents} students.");

        }
    }
}
