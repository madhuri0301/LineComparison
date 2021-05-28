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
            double a = line1.LengthOfLine(5, 7, 10, 12);
            double b = line2.LengthOfLine(5, 7, 10, 12);

            if (a.Equals(b))
            {
                Console.WriteLine("Lines Are Equal");
            }
            else
            {
                Console.WriteLine("Lines Are not Equals");
            }
        }
    }

}
