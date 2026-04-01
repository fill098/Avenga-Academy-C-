
#region Age Calculator
//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today



static string AgeCalculator(DateTime birthday)
{
    DateTime today = DateTime.Now;
    int age = today.Year - birthday.Year;

    if (birthday.Month > today.Month)
    {
        age--;
        return $"Your birthday has not happen yet, you are this {age} years old!!";
    }
    else if (birthday.Month == today.Month && birthday.Day > today.Day)
    {
        age--;
        return $"Your birthday has not happen yet, you are this {age} years old!!";
    }
    else if (birthday.Day == today.Day)
    {
        return $"HAPPY BIRTHDAY! You are {age} years old!!";
    }
    else
    {
        return $"Your birthday has alrady past, you are {age} years old!!";
    }

}

Console.WriteLine("Please enter your birthday as dd/mm/yyyy!!");

DateTime birthYearInput = DateTime.Parse(Console.ReadLine());


Console.WriteLine(AgeCalculator(birthYearInput));


//// Method 1 - just calculates and returns the number
//static int CalculateAge(DateTime birthday)
//{
//    DateTime today = DateTime.Now;
//    int age = today.Year - birthday.Year;

//    if (birthday.Month > today.Month)
//        age--;
//    else if (birthday.Month == today.Month && birthday.Day > today.Day)
//        age--;

//    return age;
//}

//// Method 2 - just builds and returns the message
//static string AgeMessage(DateTime birthday)
//{
//    int age = CalculateAge(birthday); // reuse method 1!

//    if (birthday.Month > today.Month)
//        return $"Your birthday hasn't happened yet, you are {age} years old";
//    else if (birthday.Month == today.Month && birthday.Day == today.Day)
//        return $"Happy Birthday! You are {age} years old!";
//    else
//        return $"Your birthday has passed, you are {age} years old";
//}
//The benefits of this approach:

//Reusability — you can use CalculateAge() anywhere you need just the number
//Cleaner code — each method is smaller and easier to read
//Easier to fix — if the age calculation is wrong, you only fix it in one place

//So yes, your instinct is correct and it is a good programming habit to build!


// Console.WriteLine("Enter your birthday: ");
//DateTime birthYearInput = DateTime.Parse(Console.ReadLine());

//// if you want just the number
//int age = CalculateAge(birthYearInput);
//Console.WriteLine(age);

//// if you want the message
//string message = AgeMessage(birthYearInput);
//Console.WriteLine(message);

//// or you can skip the variable and print directly
//Console.WriteLine(CalculateAge(birthYearInput));
//Console.WriteLine(AgeMessage(birthYearInput));




#endregion
