#region Task 1
//Make a console application called SumOfEven. Inside it create an array of 6 integers.
//Get numbers from the input, find and print the sum of the even numbers from the array:

//Test Data:
//Enter integer no.1:
//4
//Enter integer no.2:
//3
//Enter integer no.3:
//7
//Enter integer no.4:
//3
//Enter integer no.5:
//2
//Enter integer no.6:
//8
//Expected Output:
//The result is: 14

//int[] SumOfEven = new int[6];




//for (int i = 0; i < 6; i++)
//{

//    Console.WriteLine($"Enter integer no.{i + 1}");
//    bool isValidInput1 = int.TryParse(Console.ReadLine(), out int num1);

//    if (!isValidInput1)
//    {
//        Console.WriteLine("You have enter a string or null please enter a number!!");
//        return;
//    }
//    else
//    {
//        SumOfEven[i] = num1;
//    }


//}


//int sum = 0; 
//foreach (int number in SumOfEven)
//{   
//    if (number % 2 == 0)
//    {
//        sum += number;
//    }

//}

//Console.WriteLine("The result is: " + sum);



#endregion

#region Task 2
//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
//Test Data:
//Enter student group: (there are 1 and 2 )
//1
//Expected Output:
//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko


string[] studntNamesG1 = new string[] { "Filip", "Zdravko", "Petko", "Stanko", "Branko"};
string[] studntNamesG2 = new string[] { "Darko", "Mario", "Stefan", "Matej", "Angela"};

string operation;




do
{
    Console.WriteLine("Please eneter 1 or 2 for printing group names!!");
    operation = Console.ReadLine();

    if (operation == "1")
    {
        foreach (var nameG1 in studntNamesG1)
        {
            Console.WriteLine(nameG1);
        }
    }
    else if (operation == "2")
    {
        foreach (var nameG2 in studntNamesG2)
        {
            Console.WriteLine(nameG2);
        }
    }
    else
    {
        Console.WriteLine("You have enter a non exixting opeartion pleasse enter 1 or 2!!!");
    }

}
while (operation != "1" && operation != "2");



#endregion