namespace Class04.Generics_and_Extension_Methods.Helpers
{
    public class NonGenericListHelper
    {


        public void PrintInfoForStrings(List<string> strings)
        {
            string first = strings[0];
            string elementType = first.GetType().Name;

            Console.WriteLine($"This string has {strings.Count} elemet and is of type {elementType}");
        }
        public void PrintStrings(List<string> strings)
        {

            Console.WriteLine("\n======= Printing Strings =========");
            foreach (var item in strings)
            {
                Console.WriteLine(item);

            }
        }




        public void PrintIntegers (List<int> integers)
        {
            Console.WriteLine("\n======= Printing Integers =========");
            foreach (var item in integers)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintBooleans(List<bool> booleans)
        {

            Console.WriteLine("\n======= Printing Booleans =========");
            foreach (var item in booleans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
