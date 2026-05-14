using Class03.Homework.Models;
namespace Class03.Homework.Models
{
    public static class UserDatabasa
    {
        public static List<User> users { get; set; } = new List<User>();

        static UserDatabasa()
        {
            users.Add(new User(1, "John", 25));
            users.Add(new User(2, "Jane", 30));
            users.Add(new User(3, "Bob", 25));
            users.Add(new User(4, "Alice", 35));
            users.Add(new User(5, "Charlie", 28));
        }


        public static User SearchById(int id)
        {
            User foundUser = users.FirstOrDefault(u => u.Id == id);
            return foundUser;
        }

        public static List<User> SearchByName(string name)
        {
            List<User> nameFound = users.Where(n => n.Name.ToUpper() == name.ToUpper()).ToList();
            return nameFound;
        }

        public static List<User> SearchByAge(int age)
        {
            List<User> ageFoound = users.Where(a => a.Age == age).ToList();
            return ageFoound;
        }






    }
}
