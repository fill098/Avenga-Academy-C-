/* 
1. Create a console application that detect provided names in a provided text 🔹
The application should ask for names to be entered until the user enteres x
After that the application should ask for a text
When that is done the application should show how many times 
that name was included in the text ignoring upper/lower case
*/


List<string> names = new List<string>();

while (true)
{

    Console.WriteLine("Input names to be serached (type x to stop): ");
    string input = Console.ReadLine();

    if( input.ToUpper() == "X")
    {
        break;
    }

    names.Add(input);
}



Console.WriteLine("Input text: ");

string text = Console.ReadLine();






