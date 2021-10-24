using System;

namespace PiSim
{
    class Program
    {
        private static readonly Random Random = new Random();

        static void Main()
        {
            int countInCircle = 0;

            Console.WriteLine("Enter number of points");
            int countAll = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            for (int i = 0; i < countAll; i++)
            {
                double x = RandFrom0To1();
                double y = RandFrom0To1();

                if (x * x + y * y <= 1)
                    countInCircle++;
            }

            double result = 4 * (double) countInCircle / countAll;

            Console.WriteLine("PI = " + result);
        }

        public static double RandFrom0To1()
        {
            return Random.NextDouble();
        }
    }
}
