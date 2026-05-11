namespace Class03.Static_Classes.Helpers
{
    public static class ConsoleHelper
    {
        public static void WirteInColor(string message, ConsoleColor color = ConsoleColor.White)
        {

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

        }

        public static void WirteError(string message)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();

        }

    }
}
