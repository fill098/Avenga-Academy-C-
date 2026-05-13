namespace Class02.Homework.BaseEntity
{
    public abstract class Shape
    {
       public abstract double CalculateArea();

       public abstract double CalculatePerimeter();


        public void DisplayInfo()
        {
            Console.WriteLine($"Area - {CalculateArea()}");
            Console.WriteLine($"Perimeter - {CalculatePerimeter()}");
        }






        
            
        

    }
}
