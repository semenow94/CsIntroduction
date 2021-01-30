using System;

namespace HW_3_2
{
    //    Написать программу — телефонный справочник — создать двумерный массив 5*2, 
    //    хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Телефонный справочник");
            string[,] phoneNumbers = new string[2, 100];
            for(int i=0; i<phoneNumbers.GetLength(1);i++)
            {
                phoneNumbers[0, i] = "User" + i;
                if(i%2==0)
                {
                    phoneNumbers[1, i] = "email" + i+"@email.ru";
                }
                else
                {
                    phoneNumbers[1, i] = "+7 (900) 000-" + (1000+i);
                }
            }
            PrintMassive(phoneNumbers);
        }
        static void PrintMassive(string[,] mass)
        {
            for (int i = 0; i < mass.GetLength(1); i++)
            {
                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    Console.Write("{0,20}", mass[j, i]);
                }
                Console.WriteLine();
            }
        }
    }
}
