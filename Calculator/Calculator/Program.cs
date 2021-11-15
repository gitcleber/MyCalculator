using System;

namespace Calculator
{
    class Program
    {

        private const double _MIN_VALUE_Double = -1000;
        private const double _MAX_VALUE_Double = 1000;

        static void Main(string[] args)
        {
            double firstDouble = 0;
            double secondDouble = 0;
            double totalDouble = 0;
            bool OKBool = true;

            Console.WriteLine("Welcome to My Calculator.");

            Console.Write("\nEnter first number: ");
            OKBool = double.TryParse(Console.ReadLine(), out firstDouble);
            Console.Write("\nEnter second number: ");
            OKBool = double.TryParse(Console.ReadLine(), out secondDouble);

            totalDouble = firstDouble + secondDouble;

            Console.WriteLine($"\n{firstDouble} + {secondDouble} = {totalDouble}\n");

            Console.WriteLine("Press ENTER key to end program.");
            Console.ReadLine();
        }
    }
}
