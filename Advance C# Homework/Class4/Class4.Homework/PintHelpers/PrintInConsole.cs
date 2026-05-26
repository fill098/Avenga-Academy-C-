namespace Class4.Homework.Helpers
{
    public class PrintInConsole
    {
        public void Print<T>( T item)
        {
            Console.WriteLine(item);
        }

        public void PrintInCollection<T>( List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
