using System;

namespace HW2_1
{
    //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите температуру утром : ");
            double temp1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите температуру вечером : ");
            double temp2 = Convert.ToDouble(Console.ReadLine());
            double averageTemp = (temp1 + temp2) / 2;
            Console.WriteLine("Средняя температура за день "+averageTemp);
            Console.ReadLine();
        }
    }
}
