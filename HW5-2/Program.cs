using System;
using System.IO;

namespace HW5_2
{
    //Написать программу, которая при старте дописывает текущее время в файл «startup.txt»
    class Program
    {
        static void Main()
        {
            string filename = "startup.txt";
            string str = $"{DateTime.Now}\n";
            File.AppendAllText(filename, str);
            Console.WriteLine("Время запуска программы записано в файл startup.txt");
        }
    }
}
