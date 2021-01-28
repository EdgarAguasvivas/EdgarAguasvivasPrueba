using System;

namespace EjercicioFibonacci
{
    class Program
    {
        static int FibonacciSeries(int lenght)
        {
            int first = 0, second = 1, result = 0;

            if (lenght == 0) return 0;
            if (lenght == 1) return 1; 

            for (int i = 2; i <= lenght; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Introduce la cantidad: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FibonacciSeries(i));
            }
            Console.ReadKey();
        }

    } 
}
