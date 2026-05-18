namespace Class04.Extesion_Methods.Helpers
{
    public static class ListHelper
    {
        public static void PrintItems<T>(this List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintListInfo<T>(this List<T> items)
        {
            string listType = typeof(T).Name;

            Console.WriteLine($"This list hase {items.Count} elemets and is of type{listType}");

           
        }


    }
}
