using System;
using System.IO;

namespace HW5_3
{
    //Ввести с клавиатуры произвольный набор чисел(0...255) и записать их в бинарный файл.
    class Program
    {
        static void Main()
        {
            byte[] bytes = { 1,2,3,4,5,6,7,8,9,10 };
            string filename = "bytes.bin";
            File.WriteAllBytes(filename, bytes);
        }
    }
}
