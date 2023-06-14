using System;

namespace DemoVS
{
      class Program
    {
        static void Main(string[] args)
        {
            double Calc = AreaOfRectangle(6,5);
            Console.WriteLine(Calc);
        }
        public static double AreaOfRectangle(double a, double b)
        {
            return a * b;
        }
    }
}
