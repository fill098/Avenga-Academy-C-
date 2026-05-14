
#region PhoneBook
//Create a PhoneBook Dierror messagectionary with 5 names and phone numbers.

//Through the console ask the person to enter a name.

//Try and find that name's phone number in your PhoneBook:

//If you can find it, print it
//If you can’t, print an 


Console.WriteLine("Enter a name:");

string nameInput = Console.ReadLine();


Dictionary<string, string> phoneBook = new Dictionary<string, string>()
{
    {"Filip", "071-380-806" },
    {"Stefan", "072-300-505" },
    {"Jill", "076-580-406" },
    {"Bob", "071-680-900" },
};


bool isValid = phoneBook.TryGetValue(nameInput, out string phoneBookName);

if (isValid)
{
    Console.WriteLine($"Here is the phone number for {nameInput} number: {phoneBookName}");
}
else
{
    Console.WriteLine($"Theer is no phone number for that name: {nameInput}");
}
#endregion
