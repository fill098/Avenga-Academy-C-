using Class02.Homework.BaseEntity;

namespace Class02.Homework.Models2
{
    public class Triangle2 : Shape
    {
        public double SideA { get; set; }

        public double SideB { get; set; }

        public double SideC { get; set; }

        public Triangle2(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }


        public override double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;

            double area = Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));

            return area;
        }


        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
