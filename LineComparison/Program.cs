using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Program");
            Line line1 = new Line();
            Line line2 = new Line();
            line1.LengthOfLine(1, 2, 3, 4);
            line2.LengthOfLine(1, 2, 3, 4);
        }
    }
}
