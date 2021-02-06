using System;

namespace HW4_2
{
    //Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке.
    //Ввести данные с клавиатуры и вывести результат на экран
    class Program
    {
        static void Main()
        {
            Console.Write("Введите челые числа через пробел ");
            string[] input = Console.ReadLine().Split(' ');
            Summ(input);

        }
        public static void Summ(string[] arr)
        {
            Console.Write("Введенные числа : ");
            int summ = 0;
            for(int i=0; i<arr.Length;i++)
            {
                Console.Write(arr[i]+ " ");
                summ += Convert.ToInt32(arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма введенных чисел = {summ}"); 
        }
    }
}
