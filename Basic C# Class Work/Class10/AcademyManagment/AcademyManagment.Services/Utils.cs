using System.Security.Cryptography.X509Certificates;

namespace AcademyManagment.Services
{
    public class Utils
    {
        public string GetStringInput()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception("Please enter valid input");
            }
            return input;
        }

        public int GetValidOption(int[] validOptions)
        {
            string input = GetStringInput();
            bool isValidformant = int.TryParse(input, out int parsedInput);
            if (!isValidformant) 
            {
                throw new Exception("Invalid input format! Try again!");
            }

            bool isValidChoice = validOptions.Contains(parsedInput);
            if (!isValidChoice) 
            {
                throw new Exception("Invalid option selected! Try again.");
            }
            return parsedInput;
        }
    }
}
