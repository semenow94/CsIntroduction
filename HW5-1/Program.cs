using System;
using System.IO;

namespace HW5_1
{
    //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
    class Program
    {
        static void Main()
        {
            Console.Write("Введите любой текст : ");
            string str = Console.ReadLine();
            string filename = "text.txt";
            File.WriteAllText(filename, str);
            Console.WriteLine("Ваш текст сохранен в файле text.txt");
        }
    }
}
