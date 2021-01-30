﻿using System;

namespace HW2_2
{
    //Запросить у пользователя порядковый номер текущего месяца и вывести его название.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер текущего месяца : ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            string month;
            switch(monthNumber)
            {
                case 1: 
                    month = "Январь";
                    break;
                case 2:
                    month = "Февраль";
                    break;
                case 3:
                    month = "Март";
                    break;
                case 4:
                    month = "Апрель";
                    break;
                case 5:
                    month = "Май";
                    break;
                case 6:
                    month = "Июнь";
                    break;
                case 7:
                    month = "Июль";
                    break;
                case 8:
                    month = "Август";
                    break;
                case 9:
                    month = "Сентябрь";
                    break;
                case 10:
                    month = "Октябрь";
                    break;
                case 11:
                    month = "Ноябрь";
                    break;
                case 12:
                    month = "Декабрь";
                    break;
                default:
                    month = "Такого месяца нет";
                    break;
            }
            Console.WriteLine($"Месяц с номером {monthNumber} - это {month}");
            Console.ReadLine();
        }
    }
}
