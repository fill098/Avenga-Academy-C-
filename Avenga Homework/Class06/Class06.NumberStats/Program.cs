#region Number Stats

//Create a method called NumberStats that accepts a number. This method should:

//Find out if the number is negative or positive

//Find out if the number is odd or even

//Find out if the number is decimal or integer

//After finding all the stats it should print them like this:

//Stats for number: 25

//Positive
//Integer
//Odd
//The number should be entered in the console by the user.

//Bonus: Validate if the user is entering a number
//Bonus: Ask the user to press Y to try again or X to exit



void NumberStats(double number)
{

    if (number == 0)
    {
        Console.WriteLine($"You have enter {number} and there is no stats for that number!!");
        return;
    }

    bool isPositive = number > 0;
    bool isOddorEven = number % 2 == 0;
    bool hasDecimalParts = number % 1 != 0;


    Console.WriteLine($"The stats for the {number} are:");
    Console.WriteLine(isPositive ? "Positive" : "Negative");
    Console.WriteLine(hasDecimalParts ? "Decimal" : "Integer");


    if (hasDecimalParts)
    {
        Console.WriteLine($"You have enter the decimal number {number}, which is not Odd or Even!!");

    }
    else
    {
        Console.WriteLine(isOddorEven ? "Even" : "Odd");
    }



}


bool UserInterFace()
{
    Console.WriteLine("Enter a number: ");
    bool isValidNumber = double.TryParse(Console.ReadLine(), out double userInput);
    if (!isValidNumber)
    {
        Console.WriteLine("Not a number please enter a number!!");
        return false;

    }

    NumberStats(userInput);
    Console.WriteLine("Press any keys for a new number. Press X to exit!!");

    bool wantsToExit = Console.ReadLine().ToUpper() == "X";
    return wantsToExit;


}

while (!UserInterFace()) ;


//NumberStats(0.5);


#endregion

