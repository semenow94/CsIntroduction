using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя :");
            string userName = Console.ReadLine();
            Console.WriteLine($"Привет, {userName}, сегодня {DateTime.Now:D}");
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
