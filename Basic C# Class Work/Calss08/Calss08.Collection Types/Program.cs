

using Calss08.Collection_Types.Models;
using System.Collections;

static void PrintColectio(IEnumerable collection, string name)
{
    Console.WriteLine($"Colection {name} items: ");
	foreach (var item in collection)
	{
		Console.Write($"{item} ");
	}
    Console.WriteLine("");
    Console.WriteLine("----------------------------------------");
}
static void PrintUsers(List<User> collection, string name)
{
    Console.WriteLine($"Colection {name} items: ");
    foreach (var item in collection)
    {
        Console.WriteLine($"{item.FullName} - {item.Age} ");
    }
   
    Console.WriteLine("----------------------------------------");
}



#region Collection Types - List<>

List<int> numbers = new List<int>();

numbers.Add(1);
numbers.Add(10);
numbers.Add(123);

numbers.AddRange(11, 22, 33, 44, 55);


numbers.Remove(33);
numbers.Remove(1234); // this will not throw exeption it will retun false if non item was found.

PrintColectio(numbers, "List<int>");

List<string> names = new List<string>()
{
	"Martin",
	"Mario",
	"Filip",
	"Klementina",
	"Dragan"
};


PrintColectio(names, "List<string>");


// List of Users


List<User> users = new List<User>()
{
	new User(){Id = 1, FullName = "Filip Mihajlovski", Age = 27},
	new User(){Id = 2, FullName = "Bob Bobski", Age = 22},
	new User(){Id = 3, FullName = "Jill Wayne", Age = 18},
};


users.Remove(users[2]);

PrintUsers(users, "List<User>");
Console.WriteLine(users.Count);







#endregion


#region ArrayList

ArrayList mixedArray = new ArrayList()
{
	1,10,true,false,new User(), "Martin"
};

#endregion

#region Generic Colection - Dictionary<,>

Dictionary<string, string> songList = new Dictionary<string, string>()
{
	{"song1", "Winds of Change" },
	{"song2", "Nothing else matters" },
	{"song3", "Livinig on a prayer" }

};

Console.WriteLine(songList["song1"]);
if (songList.ContainsKey("song3"))
{
	Console.WriteLine(songList["song3"]);
}
else
{
    Console.WriteLine("Key 'song3' does not exist in the dictionery!");
}

bool item = songList.TryGetValue("song5", out string songValue);

if (item)
{
    Console.WriteLine($"Here are your song: {songValue}");
}
else
{
    Console.WriteLine("Something went wrong no such song avelable!");
}


Dictionary<int, string> students = new Dictionary<int, string>()
{
	{1,"Martin" },
	{2,"Mario" },
	{3,"Klementina" }
};

PrintColectio(students, "DIctionery of students");

foreach (var studen in students)
{
    Console.WriteLine($"{studen.Key} {studen.Value}");
}


Dictionary<int, User> trainers = new Dictionary<int, User>()
{
	{1, new User() {Id = 1, FullName = "Bob bobski", Age = 33} },
	{2, new User() {Id = 2, FullName = "Gerg Smith", Age = 25} },
	{3, new User() {Id = 3, FullName = "Jhon Doe", Age = 33} }
};

foreach (var trainer in trainers)
{
    Console.WriteLine($"{trainer.Key} {trainer.Value.FullName}");
}

Console.WriteLine(songList.Count);

#endregion


#region Generic Colection - Queue<> First in first out


Queue<int> numberQueue = new Queue<int>();
numberQueue.Enqueue(1);
numberQueue.Enqueue(2);
numberQueue.Enqueue(3);
numberQueue.Enqueue(4);
numberQueue.Enqueue(5);


numberQueue.Dequeue();

PrintColectio(numberQueue, "Queue");

int firstInTheQueue = numberQueue.Peek();
Console.WriteLine(firstInTheQueue);
Console.WriteLine(numberQueue.Count);






#endregion

#region Generic Collections - Stack<> Last in First Out

Stack<string> namesStack = new Stack<string>();
namesStack.Push("Bob");
namesStack.Push("Dimitar");
namesStack.Push("Ognen");
namesStack.Push("Damjan");
namesStack.Push("Igor");

namesStack.Pop();

PrintColectio(namesStack, "Stack<>");
Console.WriteLine(namesStack.Count);
Console.WriteLine(namesStack.Peek());


#endregion
