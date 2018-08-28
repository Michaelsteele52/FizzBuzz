using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10000; i++)
            {
                Testing(i);
            }
            Console.ReadKey();

            var boomService = new BoomServiceInheritance();
        }

        private static void Testing(int input)
        {
            IFizzBuzzCalculator baseClass = new FizzBuzzService();
            Console.WriteLine(baseClass.Calculate(input));
        }
    }
}
