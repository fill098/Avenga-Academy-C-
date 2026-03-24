#region 1
//1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
//Display the count on the console.

int count = 0;

for (int i = 1; i <= 100; i++)
{

    if (i % 3 == 0)
    {
        count++;
    }



}

Console.WriteLine("The count of divisible numbers with 3 with no remainder is: " + count);

#endregion


#region 2

//2- Write a program and continuously ask the user to enter a number or "ok" to exit.
//Calculate the sum of all the previously entered numbers and display it on the console.

//int sum = 0;
//while (true)

//{

//    Console.WriteLine("Plesse eneter a number to continue or ok to exit!!");
//	string input = Console.ReadLine();

//	if (input == "ok" || input == "OK")
//	{
//		break;
//	}
//	else
//	{
//		int input2 = int.Parse(input);
//		sum += input2;

//	}
//    Console.WriteLine("The sum of the input number is: " + sum);

//}


#endregion


#region 3

//3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
//For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
Console.WriteLine("Plesse enter a number to compute the factorial!!");
bool isValid = int.TryParse(Console.ReadLine(), out int n);


if (!isValid || n < 0)
{
    Console.WriteLine("Pleasse ennter a positive number greter then 0!!");
    return;
}

long factorial = 1;
for (int i = 2; i <= n; i++)
{

    factorial *= i;

}


Console.WriteLine($"The factorial of the number{n} is: {factorial}");







#endregion


#region 4
//4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
//If the user guesses the number, display “You won"; otherwise, display “You lost".
//(To make sure the program is behaving correctly, you can display the secret number on the console first.)


int winningNum = new Random().Next(1, 10);

Console.WriteLine("The wining number is " + winningNum);




for (int i = 4; i > 0; i--)
{
    Console.WriteLine($"Guess the secret number you have {i} chances!!");
    int input2 = Convert.ToInt32(Console.ReadLine());


    if (input2 == winningNum)
    {
        Console.WriteLine($"You guess the winnung number {winningNum}");
        return;
    }

}

Console.WriteLine("You have lost the game!!");

var number = new Random().Next(1, 10);

//Console.WriteLine("Secret is " + number);
//for (var i = 0; i < 4; i++)
//{
//    Console.Write("Guess the secret number: ");
//    var guess = Convert.ToInt32(Console.ReadLine());

//    if (guess == number)
//    {
//        Console.WriteLine("You won!");
//        return;
//    }
//}

//Console.WriteLine("You lost!");





#endregion


#region 5

//5- Write a program and ask the user to enter a series of numbers separated by comma.
//Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4",
//the program should display 8.

Console.WriteLine("Enter series of numbers separated by comma(,)!!");

string input3 = Console.ReadLine();

string[] nums = input3.Split(',');

int max = Convert.ToInt32(nums[0]);


foreach (var strItem in nums)
{
    int numArray = Convert.ToInt32(strItem);
    if (numArray > max)
    {
 max = numArray;
    }

}

Console.WriteLine("The bigest is the number: " + max);












#endregion


