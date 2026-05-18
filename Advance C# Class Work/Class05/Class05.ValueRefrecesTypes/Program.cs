using Class05.ValueRefrecesTypes;

int num1 = 10;
int num2 = num1;

num2 = 1000;

int num3 = null;
int? num4 = null;

Console.WriteLine(num1);
Console.WriteLine(num2);


Person bob = new Person("Bob" , 30);

Person john = bob;

john.Name = "John";


Console.WriteLine(bob.Name);
Console.WriteLine(john.Name);




