using System;

namespace HW4_1
{
    //Написать метод GetFullName(string firstName, string lastName, string patronymic), 
    //принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
    //Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
    class Program
    {
        static void Main()
        {
            for(int i=0;i<3;i++)
            {
                Console.Write("Введите фамилию : ");
                string firstName = Console.ReadLine();
                Console.Write("Введите имя  : ");
                string lastName = Console.ReadLine();
                Console.Write("Введите отчество  : ");
                string patronymic = Console.ReadLine();
                Console.WriteLine(GetFullName(firstName, lastName, patronymic));
            }
        }
        public static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {lastName} {patronymic}";
        }
    }
}
