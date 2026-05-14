using Class07.Enums.Enums;

Console.WriteLine(DaysOfWeek.Monday);

Console.WriteLine(Convert.ToInt32(DaysOfWeek.Monday));

Console.WriteLine("Please enter day of week");
string input = Console.ReadLine();


//if (input == "Saturday" || input == " Sunday")
//{
//    Console.WriteLine("Yeey!. It is a weekend");
//}

if (input == DaysOfWeek.Saturday.ToString() || input == DaysOfWeek.Sunday.ToString())
{
    Console.WriteLine("Yeey!. It is a weekend");
}   