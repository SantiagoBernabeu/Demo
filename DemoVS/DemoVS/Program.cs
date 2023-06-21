using System;

namespace DemoVS
{
      class Program
    {
        static void Main(string[] args)
        {
            double CalcTheFirst = AreaOfRectangle(6,5);
            double CalcTheSecond = AreaOfRectangle(6,5);
            Console.WriteLine(CalcTheFirst);
            Console.WriteLine(CalcTheSecond);
        }
        public static double AreaOfRectangle(double a, double b)
        {
            return a * b;
        }
        public static double PerimeterOfRectangle(double a, double b)
        {
            return 2 * a + 2 * b;
        }
    }
}
