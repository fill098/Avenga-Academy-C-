#region Exercise 1
//Create two variables and initialize them
//Determine which number is larger
//Determine whether the larger number is even or odd

//Output example:

//The larger number from the two is X
//And the number is even/odd


//int num1 = 88;
//int num2 = 75;

//if (num1 == num2)
//{
//    Console.WriteLine("The numbers are the same.Please enter two different values");
//}
//else if(num1 > num2)
//{
//    if(num1 % 2 == 0)
//    {
//        Console.WriteLine($"The number {num1} is larger then {num2}.The number {num1} is even number");
//    }
//    else{
//        Console.WriteLine($"The number {num1} is larger then {num2}.The number {num1} is odd number");
//    }
//}
//else
//{
//    if (num2 % 2 == 0)
//    {
//        Console.WriteLine($"The number {num2} is larger then {num1}.The number {num2} is even number");
//    }
//    else
//    {
//        Console.WriteLine($"The number {num2} is larger then {num1}.The number {num2} is odd number");
//    }

//}




#endregion

#region Exercise 2
//Ask the user to enter a number from 1 to 3:

//1 → “You got a new car!”
//2 → “You got a new plane!”
//3 → “You got a new bike!”
//Any other input → error message


//Console.WriteLine("Please enter a number from 1 to 3!");

//int number1 = 0;

//bool enterNumber = int.TryParse(Console.ReadLine(), out number1);

//if (!enterNumber)
//{
//    Console.WriteLine("You have enter a string or nothing.Please enter a number from 1 to 3.");
//    return;
//}

//switch (number1)
//{
//    case 1: Console.WriteLine("You got a new car!");
//        break;
//    case 2: Console.WriteLine("You got a new plane!");
//        break;
//    case 3: Console.WriteLine("You got a new bike!");
//        break;
//    default:
//        Console.WriteLine("Please enter a number from 1 to 3.");
//    break;
//}

#endregion

#region Exercise 3
//Create new console application called“RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25



//Console.WriteLine("Please enter the first number1!");

//bool firstNumber = int.TryParse(Console.ReadLine(), out int num3);
//Console.WriteLine("Please enter the second number1");
//bool secondeNumber = int.TryParse(Console.ReadLine(), out int num4);
//Console.WriteLine("Please enter an mathematical operation!");
//bool operation = char.TryParse(Console.ReadLine(), out char mathOperation);

//if (!firstNumber || !secondeNumber || !operation)
//{
//    Console.WriteLine("You have enter a string or nothing.Please enter two numbers and a mathematical operation!");
//    return;
//}


//switch (mathOperation)
//    {

//        case '+':

//                int sum = num3 + num4;
//                Console.WriteLine("The result  from addition is: " + sum);
//                break;

//        case '-':

//                int sub = num3 - num4;
//                Console.WriteLine("The result subtraction is: " + sub);
//                break;

//        case '*':

//                int mult = num3 * num4;
//                Console.WriteLine("The result from multiplication is: " + mult);
//                break;

//        case '/':
//                if(num4 == 0)
//        {
//            Console.WriteLine("You can not divide with 0 please enter a number real number!");
//            return;
//        }
//                double div = (double)num3 / num4;
//                Console.WriteLine("The result from division is: " + div);
//                break;


//        default:
//            Console.WriteLine("Invalid operation. Please use +, -, *, /");
//            break;
//    }









#endregion

#region Exircise 4

//Create new console application called “AverageNumber” that takes four numbers as input to calculate and print the average.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18


//Console.WriteLine("Enter the first number!");
//bool input1 = int.TryParse(Console.ReadLine(), out int num5);
//Console.WriteLine("Enter the second number!");
//bool input2 = int.TryParse(Console.ReadLine(), out int num6);
//Console.WriteLine("Enter the third number!");
//bool input3 = int.TryParse(Console.ReadLine(), out int num7);
//Console.WriteLine("Enter the forth number!");
//bool input4 = int.TryParse(Console.ReadLine(), out int num8);

//if (!input1 || !input2 || !input3 || !input4)
//{
//    Console.WriteLine("You have enter a string or noting. Please enter 4 real numbers!");
//    return;
//}


//double averageNum =(double)(num5 + num6 + num7 + num8) / 4;




//Console.WriteLine($"The average number for {num5}, {num6}, {num7}, {num8} is: {averageNum}");


#endregion


#region Exircise 5

//Create new console application called “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:

//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5

Console.WriteLine("Input the first number!");

int num9 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input the second number!");

int num10 = Convert.ToInt32(Console.ReadLine());

//This is my solution

//int num11 = num9;
//int num12 = num10;

//num9 = num12;
//num10 = num11;

//Console.WriteLine($"First number now is {num9} and the second number now is {num10}");


int temp = num9;
num9 = num10;
num10 = temp;

Console.WriteLine("After Swaping");
Console.WriteLine("First number is: " + num9);
Console.WriteLine("Second number is: " + num10);






#endregion


