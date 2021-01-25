using System;

namespace HW2_5
{
    //Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима»
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите среднюю температуру : ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите порядковый номер текущего месяца : ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            switch (monthNumber)
            {
                case 12:
                case 1:
                case 2:
                    if (temp > 0) Console.WriteLine("Дождливая зима");
                    break;
                default:
                    Console.WriteLine("Такого месяца нет");
                    break;
            }
        }
    }
}
