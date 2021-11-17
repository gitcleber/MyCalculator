using System;

namespace myCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double numCalc1, numCalc2;
            string input;
            bool OKBool;
            char operation;
            do {
                Console.Clear();
                Console.WriteLine("Calculadora - v1\n");
                Console.WriteLine("Sair - 's'");
                Console.Write(">>> ");
                input = Console.ReadLine();
                OKBool = Double.TryParse(input,out numCalc1);
                if (OKBool)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Calculadora - v1\n");
                        Console.WriteLine("soma: '+' subtração: '-' divisão: '/' multiplicação: '*' - Zerar: 'z' - Sair: 's'");
                        Console.Write($"\n>>> {numCalc1} ");
                        operation = Console.ReadKey().KeyChar;
                        if ((operation == '+') || (operation == '-') || (operation == '/') || (operation == '*'))
                        {
                            do
                            {                                
                                Console.Clear();
                                Console.WriteLine("Calculadora - v1\n");
                                Console.WriteLine("\nZerar: 'z' - Sair 's'");
                                Console.Write($"\n>>> {numCalc1} {operation} ");
                                input = Console.ReadLine();
                                OKBool = Double.TryParse(input, out numCalc2);

                                if (OKBool)
                                {
                                    switch (operation)
                                    {
                                        case '+':
                                            numCalc1 += numCalc2;
                                            break; // break that closes the case

                                        case '-':
                                            numCalc1 -= numCalc2;// Some code here
                                            break; // break that closes the case
                                        case '/':
                                            numCalc1 /= numCalc2;// Some code here
                                            break; // break that closes the case

                                        case '*':
                                            numCalc1 *= numCalc2;// Some code here
                                            break; // break that closes the case
                                    }
                                }
                                else if ((input == "z") || (input == "s"))
                                    OKBool = true;
                            } while (!OKBool);
                        }
                        else if (operation == 'z')
                            OKBool = false;
                    } while (OKBool);
                }
                else if (input == "s")
                    OKBool = true;
            } while (!OKBool);
        }
    }
}
