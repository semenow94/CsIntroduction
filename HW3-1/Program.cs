using System;

namespace HW3_1
{
    //Написать программу, выводящую элементы двухмерного массива по диагонали.
    class Program
    {
        static void Main()
        {
            Console.Write("Введите размер массива :");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] mass = CreateMassive(size);
            Console.WriteLine();
            PrintMassive(mass);
            Console.WriteLine();
            Console.WriteLine("Элемента массива по диагонали");
            PrintDiagLine(mass);
        }
        static int[,] CreateMassive(int size)
        {
            int[,] mass = new int[size, size];
            Random random = new Random();
            for(int i=0;i<size;i++)
            {
                for(int j=0;j<size; j++)
                {
                    mass[i, j] = random.Next(100);
                }
            }
            return mass;
        }
        static void PrintMassive(int[,] mass)
        {
            for (int i = 0; i < mass.GetLength(1); i++)
            {
                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    Console.Write("{0,5}",mass[j,i]);
                }
                Console.WriteLine();
            }
        }
        static void PrintDiagLine(int[,] mass)
        {
            for(int i=0; i<mass.GetLength(0); i++)
            {
                Console.Write("{0,5}", mass[i, i]);
            }
        }
    }
}
