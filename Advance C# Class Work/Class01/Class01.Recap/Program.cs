// Static Demo  Recap 


//using Class01.Recap;
//using System.Xml.Linq;


//void HelloWordl()
//{
//    Console.WriteLine("Hello World");
//}
//HelloWordl();


//var mario = new Developer("Mario", "Rose", 30);

//Console.WriteLine(mario);
//Console.WriteLine(mario.GetNumberOfDevelopers());
//Console.WriteLine(Developer.NumberOfDevelopers);
//Developer.ResetNumOfDevelopers();

//Console.WriteLine(Developer.NumberOfDevelopers);



//Console.ReadLine();

//// Step 1: Collect names until user enters "x"
//List<string> names = new List<string>();

//Console.WriteLine("=== Name Detector ===");
//Console.WriteLine("Enter names one by one. Type 'x' to stop.\n");

//while (true)
//{
//    Console.Write("Enter a name: ");
//    string input = Console.ReadLine();

//    if (input != null && input.Trim().ToLower() == "x")
//        break;

//    if (!string.IsNullOrWhiteSpace(input))
//        names.Add(input.Trim());
//}

//if (names.Count == 0)
//{
//    Console.WriteLine("\nNo names were entered. Exiting.");
//    return;
//}

//// Step 2: Ask for the text
//Console.WriteLine("\nEnter the text to search in:");
//string text = Console.ReadLine() ?? string.Empty;

//// Step 3: Count occurrences of each name (case-insensitive)
//Console.WriteLine("\n=== Results ===");

//foreach (string name in names)
//{
//    int count = CountOccurrences(text, name);
//    Console.WriteLine($"'{name}' was found {count} time(s) in the text.");
//}


//static int CountOccurrences(string text, string name)
//{

//    if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(name))
//        return 0;

//    int count = 0;
//    int index = 0;

//    string textLower = text.ToLower();
//    string nameLower = name.ToLower();

//    while ((index = textLower.IndexOf(nameLower, index)) != -1)
//    {
//        count++;
//        index += nameLower.Length;
//    }

//    return count;
//}

//1.Create a console application that detect provided names in a provided text 🔹
//The application should ask for names to be entered until the user enteres x
//After that the application should ask for a text
//When that is done the application should show how many times that name was included in the text ignoring upper/lower case


// Step 1: Collect names until user enters "x"

List<string> names2 = new List<string>();
while (true)
{
    string input  = Console.ReadLine();
    if(input.ToLower() == "x")
    {
        break;
    }
    names2.Add(input);
}


// Step 2: Ask for the text

string text2 = Console.ReadLine();

string[] spliText = text2.Split(' ');



// Step 3: Count occurrences of each name (case-insensitive)

foreach(var name in names2)
{
    Console.WriteLine(names2);
}