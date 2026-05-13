using Class02.Homework.BaseEntity;
using Class02.Homework.Interface;

namespace Class02.Homework.Models
{
    public class Circle : IShape
    {
        public double Radius { get; set; }


        
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return (Radius * Radius) * double.Pi;
        }

        
    }
}
