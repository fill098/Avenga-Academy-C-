namespace Class06.HelperMethod
{
    public class Helper
    {
        public static int GetIntInputInRange(string promptText, int min , int max , bool oneLine = false)
        {
            while (true)
            {
                if (oneLine) Console.Write(promptText);
                else Console.WriteLine(promptText);

                bool isValid = int.TryParse(Console.ReadLine().Trim(), out int result);

                if (!isValid)
                {
                    Console.WriteLine("That isn't a valid whole number. Please try again.");
                    continue;   
                }

                if (result < min || result > max)
                {
                    Console.WriteLine($"Please enter a number between {min} and {max}.");
                    continue;
                }

                return result;
            }
        }

        public static int GetIntInput(string promptText, bool oneLine = false)
        {
            while (true)
            {
                if (oneLine) Console.Write(promptText);
                else Console.WriteLine(promptText);

                bool isValid = int.TryParse(Console.ReadLine().Trim(), out int result);

                if (!isValid)
                {
                    Console.WriteLine("That isn't a valid whole number. Please try again.");
                    continue;
                }

               

                return result;
            }
        }

        public static bool GetYesNoInput(string promptText, bool oneLine = false)
        {
            while (true)
            {
                if (oneLine) Console.Write(promptText);
                else Console.WriteLine(promptText);

                string input = Console.ReadLine().Trim().ToLower();

                if (input == "y") return true;
                if (input == "n") return false;

                Console.WriteLine("Please enter Y or N.");
            }
        }


    }
    
}