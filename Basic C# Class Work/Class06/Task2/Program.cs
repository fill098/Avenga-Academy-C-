using Task2.Models;

#region Task2

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
    new User { ID = 1, UserName = "alice", Password = "pass123", Messages = new string[] { "Hello Alice!", "Your order has shipped.", "Meeting at 3pm." } },
    new User { ID = 2, UserName = "bob",   Password = "bob456",  Messages = new string[] { "Hey Bob!", "You have a new friend request." } },
    new User { ID = 3, UserName = "carol", Password = "carol789", Messages = new string[] { "Welcome to the platform!", "Your profile is complete." } }

};

 void LogIn()
{
    Console.WriteLine("Enter username");
    string userNameInput = Console.ReadLine();
    Console.WriteLine("Enter a password");
    string passwordInput = Console.ReadLine();


    foreach(var user in users)
    {
        if(user.UserName == userNameInput && user.Password == passwordInput)
        {
            Console.WriteLine($"Log in Wellcom you have these meseges {user.Messages[0]}");
        }
        else
        {
            Console.WriteLine("There is no username with that password found");
            
        }
    }

}

void Register()
{
    Console.WriteLine("Enter ID name:");
    string registerId = Console.ReadLine();
    Console.WriteLine("Enter a username:");
    string registerUsername = Console.ReadLine();
    Console.WriteLine("Enter a password:");
    string registerPassword = Console.ReadLine();

}



Console.WriteLine("Chouse 1 - Log In and 2 - Register!!");

string input = Console.ReadLine();












#endregion