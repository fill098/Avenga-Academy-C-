using Class06._Anonymous_Methods_and_Advanced_LINQ.Models;

#region Func
List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve","John" };

List<string> empty = [];


// => One line lambda expression
string johnName = names.Find(name => name == "John");

//foreach (var name in names)
//{
//	if (name == "John")
//	{
//		return true;
//	}
//}


// => Multiple line lambda expression

string johnName2 = names.Find(name =>
{
    if (name == "John")
    {
        return true;
    }
    return false;
});


// in JavaScript, we can write:
// const sum = (num1,num2) => num1 + num2;
//sum(10,20) // 30

// parameater 1 => int
// parameter 2 => int
// return type => int

// ===> Example of Func with two parameters and a return type
Func<int, int, int> sum = (num1, num2) => num1 + num2;

int result = sum(10, 20); // 30

Console.WriteLine(result);

// ===> Func with no parameters and a return type

Func<bool> isNamesEmpty = () => empty.Count == 0;

Console.WriteLine("Is list empty " + isNamesEmpty());

// ===> Func with one parameter and a return type


Func<List<string>, bool> isListEmpty = list => list.Count == 0;

Console.WriteLine("The lsit names is " + isListEmpty(names));
Console.WriteLine("The lsit names is " + isListEmpty(empty));



Func<int, int, bool> isLarger = (num1, num2) =>
{
    if (num1 > num2)
    {
        return true;
    }
    return false;
};

//===> Func with 4 parameters and a return type

Func<int, string, double, bool, string> getUserInfo = (id, name, salary, isActive) =>
{
    return $"ID: {id}, Name: {name}, Salary: {salary}, Active: {(isActive ? "Yes" : "No")}";
};


string userInfo = getUserInfo(1, "Alice", 50000.0, true);

Console.WriteLine(userInfo);

//===> Func that uses the Person class and returns a string

Func<Person, string> getPersonName = person => person.Name;

Person bob = new Person { Name = "Bob" };

Console.WriteLine(getPersonName(bob));

//Func must return a value, so we cannot use it for void methods. For that, we can use Action delegate
#endregion

#region Action
//Func<void> printHello = () => Console.WriteLine("Hello");

// Action with no parameters and no return type
Action printHello2 = () => Console.WriteLine("Hello");

printHello2();

Action<string> printRed = word =>
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(word);
    Console.ResetColor();
};

printRed("This is a red word");

Action<string, ConsoleColor> printInColor = (text, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
};

printInColor("This is a green word", ConsoleColor.Green);







#endregion

#region Predicate
// Predicate is a delegate that takes one parameter and returns a boolean value

Predicate<Person> isActive = person => person.IsActive;

Person bob2 = new();
Console.WriteLine(isActive(bob2));

#endregion

#region LINQ with Delegates
string foundBob = names.Find(name => name == "Bob");

Predicate<string> isJill = name => name == "Jill";

string foundJill = names.Find(isJill);

Func<string, bool> isJillFunc = name => name == "Jill";

string foundJillFirstOrDefault = names.FirstOrDefault(isJillFunc);

Func<string, bool> startsWithJ = name => name.StartsWith("J");

List<string> namesWithJ = names.Where(startsWithJ).ToList();
List<string> namesWithJ2 = names.Where(n => startsWithJ(n)).ToList();
List<string> namesWithJ3= names.Where(n => n.StartsWith('J')).ToList();

namesWithJ.ForEach(n => Console.WriteLine(n));
namesWithJ.ForEach(Console.WriteLine);

#endregion

Console.ReadLine();

