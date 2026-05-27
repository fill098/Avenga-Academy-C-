namespace Class07.Events_and_Delegates
{
    public class DelegatesService
    {
        private delegate int CalculationDelegate(int num1, int num2);

        private delegate void SayDelegate(string text);

        public int MyProperty { get; set; }

        private void SayHello(string text)
        {
            Console.WriteLine(text);
        }

        private void SayWhatever (string whatever, SayDelegate sayMethod)
        {
            sayMethod(whatever);
        }

        private double Calculation(int num1, int num2, CalculationDelegate)
        public void Run()
        {
            Console.WriteLine("Hello, World!");

            Func<int, int, int> subtractFunc = (num1, num2) => num1 - num2;
            int result = subtractFunc(10, 5);
            Console.WriteLine($"Subtraction result: {result}");


            Action<string, ConsoleColor> printWithColor = (text, color) =>
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
            };

            printWithColor("This is a colored message!", ConsoleColor.Green);

            CalculationDelegate subtract = (num1, num2) => num1 - num2;
            Console.WriteLine(subtract(10,20));

            SayDelegate sayHello = new SayDelegate(word => Console.WriteLine(word));

            sayHello("Hello");


            SayDelegate sayHelloAgain = new SayDelegate(SayHello);

            prop
        }
    }
}
