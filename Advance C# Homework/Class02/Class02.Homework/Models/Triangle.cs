using Class02.Homework.BaseEntity;
using Class02.Homework.Interface;

namespace Class02.Homework.Models
{
    public class Triangle : IShape
    {
        public double Base { get; set; }

        public double Height { get; set; }

        public Triangle(double base1, double height )
        {
            Base = base1;
            Height = height;
        }

        public double GetArea()
        {
            return (Base * Height) * 0.5;
        }

        
    }
}
