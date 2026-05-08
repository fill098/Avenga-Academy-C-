#region EXERCISE 3
//Declare 5 arrays with 5 elements in them:

//With words
//With decimal values
//With characters from keyboard
//With true/false values
//With arrays, each holding 2 whole numbers

using static System.Runtime.InteropServices.JavaScript.JSType;

string[] words = new string[]
{
    "Martin",
    "Stefan",
    "Bob",
    "Ivan",
    "Matea",
    "Milena",

};



double[] decimalNum = [10.666666, 6.602, 23.23, 46.34, 0.353, 0.23];


char[] keyboardChar = ['f', 'g', 'G', 'h', 's'];

bool[] arrayThrueAndFalse = [true, false, false, false, false, true, true];

int[,] array1 = { { 2, 4 }, { 5, 8 }, { 2, 9 }, { 0, 0 }, { 0, -2 } };



#endregion

#region EXERCISE 4
//Declare a new array of integers with 5 elements
//Initialize the array elements with values from input
//Sum all the values and print the result in the console


//int[] numArraye = new int[5];
//int sum = 0;
//for (int i = 0; i < numArraye.Length ; i++)
//{
//    Console.WriteLine($"Enter the {i + 1} number for an array");
//    int input = int.Parse(Console.ReadLine());


//    numArraye[i] = input;
//}

//foreach (int num1 in numArraye)
//{

//    sum += num1;
//}

//Console.WriteLine("This is the resulting array sum!!");
//Console.WriteLine($"The sum of the array is: {sum}");


#endregion

#region EXERCISE 5
//Create an array with names
//Give an option to the user to enter a name from the keyboard
//After entering the name put it in the array
//Ask the user if they want to enter another name(Y / N)
//Do the same process over and over until the user enters N
//Print all the names after user enters N


string[] arrayNames = ["Filip", "Martin"];

do
{
    Console.WriteLine("Plesse enter a name!!");
    string userInput = Console.ReadLine();
    Array.Resize(ref arrayNames, arrayNames.Length + 1);
    arrayNames[arrayNames.Length - 1] = userInput;
    Console.WriteLine("Do you want to enter another name Y or N!!.");
    userInput = Console.ReadLine();
    if (userInput == "n" || userInput == "N")
    {
        break;
    }


}
while (true);


foreach (string names2 in arrayNames)
{
    Console.Write(names2);
}









#endregion
