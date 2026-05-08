void NumbersStats(double number)
{
    bool isNegativ = number > 0 ? false : true;
    bool isDecimal = number % 1 > 0 ? true : false;
    bool isEven = number % 2 == 0 ? true : false;

    Console.WriteLine($"Stats for number: {number}");
    Console.WriteLine(string.Format("{0}", isNegativ ? "negativ" : "positiv"));
    Console.WriteLine(string.Format("{0}", isDecimal ? "decimal" : "intiger"));
    Console.WriteLine(string.Format("{0}", isEven ? "even" : "odd"));
    
}

bool UserInterface()
{
    Console.WriteLine("Enter a number");
    bool isUserInputParsed = double.TryParse(Console.ReadLine(), out double userInput);

}