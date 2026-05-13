using Class02.Homework.BaseEntity;

namespace Class02.Homework.Models2
{
    public class Rectangle2 : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle2(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }


        public override double CalculatePerimeter()
        {
            return (Width + Height) * 2;
        }
    }
}
