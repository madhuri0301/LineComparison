using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string []args)
        {
            Console.WriteLine("Welcome To Line Comparison Program");
            Line line1 = new Line();
            Line line2 = new Line();
            double a = line1.LengthOfLine(3, 7, 10, 12);
            double b = line2.LengthOfLine(5, 7, 10, 12);
          
            double c = (a.CompareTo(b));
            if (c == 0)
            {
                Console.WriteLine("Lines Are Equal");
            }
            else if (c == 1)
            {
                Console.WriteLine("Line One Is Greater Than Line Two");
            }
            else 
            {
                Console.WriteLine("Line Two Is Greater Than Line One");
            }
        }
    }

}
