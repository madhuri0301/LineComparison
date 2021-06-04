using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    public abstract class Line
    {
        public abstract double LengthOfLine(double x1, double y1, double x2, double y2);
    }
    public class Length : Line
    {
        public override double LengthOfLine(double x1, double y1, double x2, double y2)
        {
            double Distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(Distance);
            return Distance;
        }
    }
}

