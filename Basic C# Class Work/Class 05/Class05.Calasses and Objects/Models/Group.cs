namespace Class05.Calasses_and_Objects.Models
{
    internal class Group
    {

        public string GroupName { get; set; }

        public int NumOfStudents { get; set; }

        public string CurrentSubjctName { get; set; }

        public Group()
        {
            
        }

        public Group( string gropName, int numOfStudents, string currentSubjectName)
        {
            GroupName = gropName;
            NumOfStudents = numOfStudents;
            CurrentSubjctName = currentSubjectName;

        }

        public void DisplayGroupInfo()
        {
            Console.WriteLine($"This is a group {GroupName} with number os students {NumOfStudents} and they are studinig {CurrentSubjctName}");
        }
    }
}
