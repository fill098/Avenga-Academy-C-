using Class02.Homework.BaseEntity;
using Class02.Homework.Interface;

namespace Class02.Homework.Models
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        
        public double GetArea()
        {
            return (Width * Height);
        }

    }
}
