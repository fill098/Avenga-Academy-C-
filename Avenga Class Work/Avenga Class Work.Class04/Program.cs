
#region Methods declaration and usage 


static void SaySomething()
{
    Console.WriteLine("Helo there I am lerninnig C# Methods!");
    Console.ReadLine();
}


SaySomething();


static void SayHelloToSomeone(string person)
{
    Console.WriteLine("Hello there " + person + " I have to tell you something");
    Console.ReadLine();
}

SayHelloToSomeone("Damjan");
SayHelloToSomeone("Filip");

static void SendEmail(bool isSenderValid, string message)
{
    if (isSenderValid == true)
    {
        Console.WriteLine("The mesage was sent! Message: " + message);
    }
    else
    {
        Console.WriteLine("The mesage was not sent! mesage: " + message);
    }

    Console.ReadLine(); 
}


SendEmail(true, "Hi martin, here is my C# homework");
SendEmail(false, "Hi martin, here is my JS homework");



static int Sum(int a, int b)
{
    return a + b;
}


Sum(10, 22);
Sum(100, 1232);


static double Subtract(double a, double b)
{
    return a - b;
}




static double Multiply(double a, double b)
{
    return a * b;
}


static double Divide(double a, double b)
{
    return a / b;
}




Console.WriteLine("Enter first number");
bool isValidFirstNum = double.TryParse(Console.ReadLine(), out double num1);
Console.WriteLine("Enter second number");
bool isValidSeconNum = double.TryParse(Console.ReadLine(), out double num2);

Console.WriteLine("Ask the user to enter * or /");
string op = Console.ReadLine();




if (!isValidFirstNum || !isValidSeconNum)
{
    Console.WriteLine("You have enter string or null please enter two numbers");

}
else if (op == "*")
{

    double result = Multiply(num1, num2);
    Console.WriteLine(result);
}
else if (op == "/")
{
    if( num2 == 0)
    {
        Console.WriteLine("You have enter 0 for divide, you can not divide with 0");
    }
    else
    {
        double result = Divide(num1, num2);
        Console.WriteLine(result);
    }
}
else
{
    Console.WriteLine("Please enter * or / and two numbers!!");
}

   








//Console.WriteLine(Subtract(100, 40));
//Console.WriteLine(Subtract(2, 10));









#endregion