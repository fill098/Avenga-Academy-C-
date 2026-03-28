
#region 1
//When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

//If no one likes your post, it doesn't display anything.
//If only one person likes your post, it displays: [Friend's Name] likes your post.
//If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
//If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
//Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
//Depending on the number of names provided, display a message based on the above pattern.

//using System.ComponentModel;

//string inputName;
//var names = new List<string>() { };



//do
//{
//    Console.WriteLine("Enter names and press enter for a message!!");

//    inputName = Console.ReadLine();

//    //string.IsNullOrWhiteSpace(inputName);
//    if (!string.IsNullOrEmpty(inputName))
//    {
//        names.Add(inputName);
//    }









//}
//while (!string.IsNullOrWhiteSpace(inputName));


//if (names.Count == 1)
//{

//    Console.WriteLine($"{names[0]} likes your post!!");
//}
//else if (names.Count == 2)
//{
//    Console.WriteLine($"{names[0]} and {names[1]} likes your post!!");
//}
//else if(names.Count > 2)
//{
//    Console.WriteLine($"{names[0]} and {names[1]} and {names.Count - 2} likes your post!!");
//}



#endregion

#region 2
//Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string.
//Display the reversed name on the console.


//Console.WriteLine("Enter your name!!");

//string inputNameUser = Console.ReadLine();

//char[] nameCharArray = inputNameUser.ToCharArray();

//Array.Reverse(nameCharArray);

//string reversedName = new string(nameCharArray);

//Console.WriteLine("Your name revers is: " + reversedName);


#endregion

#region 3

//Write a program and ask the user to enter 5 numbers. If a number has been previously entered, 
//display an error message and ask the user to re-try. 
//Once the user successfully enters 5 unique numbers, sort them and display the result on the console.


Console.WriteLine("Enter 5 unique numbers!!");
string num1;
string num2;

do
{
    Console.WriteLine("Enter first number!!");
    num1 = Console.ReadLine();
    Console.WriteLine("Enter second number!!");
    num2 = Console.ReadLine();

} while (num1 != num2);

Console.WriteLine("Sucses");

Console.WriteLine("Enter first number!!");
num1 = Console.ReadLine();
Console.WriteLine("Enter second number!!");
num2 = Console.ReadLine();

for (int i = 0; i < length; i++)
{
    
}



#endregion