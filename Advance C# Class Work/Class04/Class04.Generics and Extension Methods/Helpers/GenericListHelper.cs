namespace Class04.Generics_and_Extension_Methods.Helpers
{
    public class GenericListHelper
    {
        public void PrintItems<T>(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintItemsInfo<T> (List<T> items)
        {
            
            string elementType = typeof(T).Name;
            string elementType2 = nameof(T);

            Console.WriteLine($"This string has {items.Count} elemet and is of type {elementType}");
        }


    }
}
