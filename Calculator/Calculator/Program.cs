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
            do
            {
                Console.Write("\nEnter first number: ");
                OKBool = double.TryParse(Console.ReadLine(), out firstDouble);

                if (OKBool)
                {
                    do
                    {
                        Console.Write("\nEnter second number: ");
                        OKBool = double.TryParse(Console.ReadLine(), out secondDouble);

                        if (OKBool)
                        {
                            totalDouble = firstDouble + secondDouble;

                            Console.WriteLine("\n{0} + {1} = {2}\n",
                                firstDouble, secondDouble, totalDouble);
                        }
                    } while (!OKBool);
                }
            } while (!OKBool);

            Console.WriteLine("Press ENTER key to end program.");
            Console.ReadLine();
        }
    }
}
