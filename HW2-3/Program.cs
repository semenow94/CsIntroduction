using System;

namespace HW2_3
{
    //Определить, является ли введённое пользователем число чётным.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine($"Число {number} является четным ");
            }
            else
            {
                Console.WriteLine($"Число {number} является нечетным ");
            }
            Console.ReadLine();
        }
    }
}
