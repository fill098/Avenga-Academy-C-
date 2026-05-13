using Class02.Homework.BaseEntity;

namespace Class02.Homework.Models2
{
    public class Circle2 : Shape
    {
        public double Radius { get; set; }

        public Circle2(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return (Radius * Radius) * Math.PI;
        }

        public override double CalculatePerimeter()
        {
            return (2 * Math.PI) * Radius;
        }
    }
}
