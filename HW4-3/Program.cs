using System;

namespace HW4_3
{
    //Написать метод по определению времени года.
    //На вход подаётся число – порядковый номер месяца.
    //На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
    //Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года(зима, весна, лето, осень). 
    //Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
    //Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
    class Program
    {
        static void Main()
        {
            Console.Write("Введите порядковый номер месяца : ");
            bool checkInput = false;
            int months=0;
            while (!checkInput)
            {
                months = Convert.ToInt32(Console.ReadLine());
                if (months <= 1 || months >= 12)
                {
                    Console.Write("Ошибка: введите число от 1 до 12 : ");
                }
                else checkInput = true;
            }
            PrintSeasonName(GetSeason(months));

        }
        static SeasonsOfTheYear GetSeason(int months)
        {
            switch (months)
            {
                case 3:
                case 4:
                case 5:
                    return SeasonsOfTheYear.Spring;
                case 6:
                case 7:
                case 8:
                    return SeasonsOfTheYear.Summer;
                case 9:
                case 10:
                case 11:
                    return SeasonsOfTheYear.Autumn;
                case 12:
                case 1:
                case 2:
                    return SeasonsOfTheYear.Winter;
            }
            return SeasonsOfTheYear.Winter;
        }
        static void PrintSeasonName(SeasonsOfTheYear season)
        {
            switch (season)
            {
                case SeasonsOfTheYear.Winter:
                    Console.WriteLine("Зима");
                    break;
                case SeasonsOfTheYear.Spring:
                    Console.WriteLine("Весна");
                    break;
                case SeasonsOfTheYear.Summer:
                    Console.WriteLine("Лето");
                    break;
                case SeasonsOfTheYear.Autumn:
                    Console.WriteLine("Осень");
                    break;
            }
        }
    }
    enum SeasonsOfTheYear
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }
}
