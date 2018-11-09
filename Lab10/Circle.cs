using System;

namespace Lab10
{
    public class Circle
    {
        private double pi = Math.PI;

        public Circle(double radius)
        {
        }
        public int radiusInput { get; set; }

        public double circumference(double radiusInput)
        {
            double circumference = 2 * pi * radiusInput;
            return circumference;
        }
        public double CalculateFormattedCircumference(double circumference)
        {
            double trimedCircumference = Math.Round(circumference, 2);
            Console.WriteLine($" The circumference is {trimedCircumference}");
            return trimedCircumference;
        }
        public double area(double radiusInput)
        {
            double area = pi * (radiusInput * radiusInput);
            return area;
        }
        public double CalculateFormattedArea(double area)
        {
            double trimedArea = Math.Round(area, 2);
            Console.WriteLine($" The area is {trimedArea}");
            return trimedArea;

        }
        
    }
}
