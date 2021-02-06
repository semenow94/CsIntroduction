using System;

namespace HW4_4
{
    //Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.
    class Program
    {
        static void Main()
        {
            Console.Write("Введите порядковый номер числа фибоначчи : ");
            bool checkInput = false;
            int input = 0;
            while (!checkInput)
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input < 0)
                {
                    Console.Write("Введите положительное число : ");
                }
                else checkInput = true;
            }
            Console.WriteLine("Данное число - "+Fibonacci(input));
        }
        static int Fibonacci(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else if (number == 0)
            {
                return 0;
            }
            else
            {
                return Fibonacci(--number) + Fibonacci(--number);
            }
        }
    }
}
