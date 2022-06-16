using System;

namespace AlgoHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Фибоначчи (стандартное вычисление)");
            mark1:
                Console.Write("Введите число для стандартного вычисления: ");
                if (uint.TryParse(Console.ReadLine(), out uint number))
                {
                    Console.WriteLine("Фибоначчи от введённого числа: " + FibStd(number));
                }
                else
                {
                    goto mark1;
                }
            mark2:
                Console.WriteLine("Фибоначчи (рекурсивное вычисление)");
                Console.Write("Введите число для рекурсивного вычисления: ");
                if (uint.TryParse(Console.ReadLine(), out uint number2))
                {
                    Console.WriteLine("Фибоначчи от введённого числа (рекурсивно): " + FibRec(number2));
                }
                else
                {
                    goto mark2;
                }

                PrimeSieve();
                Console.ReadKey(true);
            } catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        

        }
        static uint FibStd(uint n)
        {
            uint a0 = 0;
            uint a1 = 1;
            uint a = a1;
            for (int i = 2; i <= n; i++)
            {
                a = a0 + a1;
                a0 = a1;
                a1 = a;
            }
            return a1;
        }

        static uint FibRec(uint n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibRec(n - 1) + FibRec(n - 2);
        }

        static void PrimeSieve()
        {
            Console.WriteLine("Определение простых и составных чисел");
            Console.Write("Введите число (uint): ");
            uint n = uint.Parse(Console.ReadLine());
            uint d = 0;
            uint i = 2;
        mark3:
            
            if (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    goto mark4;

                }
                else
                {
                    goto mark4;
                }
                mark4:
                
                {
                
                    i++;
                    goto mark3;
                }
            } else
            {
                if (d == 0)
                {
                    Console.WriteLine("Простое");
                } else
                {
                    Console.WriteLine("Не простое");
                }
            }

        }
    }
}
