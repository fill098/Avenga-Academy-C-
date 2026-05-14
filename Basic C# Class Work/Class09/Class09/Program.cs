
#region Error Handling and Exceptions
Console.WriteLine("---------------------------- Exemple 1 ----------------------------");
try
{
    Console.WriteLine("Enter a number:");
    int number = Int32.Parse(Console.ReadLine());

    Console.WriteLine($"The number you entered is: {number}");
}
catch (Exception ex)
{

    Console.WriteLine("Ooops, something went wrong! Please try again later");
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine($"Info for  devoloper: {ex.Message}");
    Console.WriteLine($"{ex.StackTrace}");
}
finally
{
    Console.WriteLine("---------------- Press any keky to continue ---------------");

    Console.ReadLine();
}

// Custom Exepcition or Exception with our own logic

Console.WriteLine("---------------------------- Exemple 2 ----------------------------");
Console.WriteLine("Handling exception with custom message");

try
{
    Console.WriteLine("Enter lettet a or letter b:");
    string letter = Console.ReadLine().Trim().ToLower();
    if (letter == "a" || letter == "b")
    {
        Console.WriteLine("Congratulatios, you have entered a or b!");
    }
    else
    {
        throw new Exception("That is not a or b! Sorry!", new Exception ( $"Incorect input : {letter}."));
    }
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
    Console.WriteLine("More info:" + ex.InnerException);
}
finally
{
    Console.WriteLine("---------------- Press any keky to continue ---------------");

    Console.ReadLine();
}

#endregion

#region Handling specific exceptions


try
{
    Console.WriteLine("Enter some charachter:");

    char char1 = char.Parse(Console.ReadLine());
    Console.WriteLine($"The charchter you entered is: {char1}");

    Console.WriteLine("Please enter a number: `");
    int number1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine($"THe number you have entered is: {number1}");

}
catch (FormatException frmEx)
{

    Console.WriteLine("You have entered somthing other then a charchter!");
}
catch(OverflowException ovEx)
{
    Console.WriteLine("You have entered either too large or to small number!!");
}
catch(Exception ex)
{
    Console.WriteLine("Somthing went wrong");
}
finally
{
    Console.WriteLine("---------------- Press any keky to continue ---------------");

    Console.ReadLine();

}
#endregion

#region Handling exception within a method

static void PersonSkill()
{

}

#endregion