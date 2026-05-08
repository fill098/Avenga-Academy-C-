
using Class06.LogIn_Homework.Models;

#region UserInterFace
//Create a class User with the following:

//Id - int
//Username - string
//Password - string
//Messages - Array of strings
//Create an array of users and add 3 users to it manually ( hard-coded ).

//Create a Console UI that will ask the user:

//Log in - When selected the user should be asked for username and password.
//If the user is found print welcome message and the messages that the user has in the Messages property:
//Welcome NAME. Here are your messages:
//Message1
//Message2
//If not found, it should print an error message
//Register - When selected the user should be asked to enter ID, Username and password.
//It should then check if a there is already a username in the array of users like that.
//If there is, print a message that there is already a user called like that.
//If not, create a new user object from the information given in the console and add it to the Users array.
//Then print all the users by Id and Username
//Registration complete! Users:
//23 Username1
//44 Username2
//1 Username3
//56 Username4


User[] users = new User[]
{
    new User (1, "bob", "test123",  new string[]{"Hi ther bob. Nice to meat you!!"}),
    new User (2, "filip", "test123",  new string[]{"Hi ther bob. Nice to meat you!!"}),
    new User (3, "darko", "test123",  new string[]{"Hi ther bob. Nice to meat you!!"})
};


bool UserUI()
{
    Console.Clear();
    Console.WriteLine("Select: \n 1 - Logi In \n 2 - Register \n 3 - Exit");
    bool isValidChoice = int.TryParse(Console.ReadLine(), out int choice);

    if (!isValidChoice || choice > 3 || choice < 1)
    {
        Console.WriteLine("Invalid input. Please enter from the 3 chooses!!");

        Console.ReadLine();
        return false;
    }

    switch (choice)
    {
        case 1:
            LogIn();
            return false;
        case 2:
            Register();
            return false;

        case 3:
            return true;
        default:
            break;
    }
    return false;


}


void LogIn()
{
    Console.Write("Enter username:");
    string username = Console.ReadLine();
    Console.Write("Enter password:");
    string password = Console.ReadLine();
    User foundUser = FindUser(username, password);
    if (foundUser != null)
    {
        Console.WriteLine("=================================");
        Console.WriteLine($"Sucsecfuly log in {foundUser.UserName}!!");
        Console.WriteLine("=================================");
        Console.WriteLine("Your meseges are!!");
        foreach (string msg in foundUser.Messages)
        {
            Console.WriteLine(msg);
        }
    }

    WhantsToExitLogIn();









}


void Register()
{

    Console.Write("Enter username:");
    string username = Console.ReadLine();
    Console.Write("Enter password:");
    string password = Console.ReadLine();

    User exitingUser = FindUser(username, password);

    if (exitingUser != null)
    {
        Console.WriteLine("User alrady in the data base!!");
        return;
    }

    Array.Resize(ref users, users.Length + 1);
    users[users.Length - 1] = new User(users.Length, username, password, null);

    Console.WriteLine("=================================");
    Console.WriteLine("Successful registraition!!");
    Console.WriteLine("=================================");
    Console.WriteLine("Registration complete! Users:");
    foreach (User user in users)
    {
        Console.WriteLine($"{user.ID} {user.UserName}");
    }

    WhantsToExitLogIn();





}

User FindUser(string username, string password)
{
    foreach (User user in users)
    {
        if (user.UserName == username && user.Password == password)
        {
            return user;
        }
    }

    return null;
}


void WhantsToExitLogIn()
{

    Console.WriteLine("=================================");
    Console.WriteLine("Click S to start again!!");

    bool exit = Console.ReadLine().ToUpper() == "S";

    if (exit == true)
    {
        return;
    }

}






while (!UserUI()) ;



#endregion