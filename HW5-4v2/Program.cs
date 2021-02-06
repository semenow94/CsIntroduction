using System;
using System.Collections.Generic;
using System.IO;

namespace HW5_4v2
{
    //Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
    //Без рекурсии и без использования стандартных методов
    class Program
    {
        static void Main()
        {
            Console.Write("Введите полное название директории : ");
            string dir = Console.ReadLine();
            string textFile = "Folders.txt";
            List<string> fileList = new List<string>();
            if (Directory.Exists(dir))
            {
                WriteFiles(dir, ref fileList);
                File.WriteAllLines(textFile, fileList);
            }
            else
            {
                Console.WriteLine("Такой директории не существует");
            }
        }
        static void WriteFiles(string dirName, ref List<string> fileList)
        {
            bool flag = true;
            int i = 0;
            fileList.Add(dirName);
            while(flag)
            {
                List<string> addToBaseList = new List<string>();
                if (Directory.Exists(fileList[i]))
                {
                    addToBaseList.AddRange(Directory.GetDirectories(fileList[i]));
                    addToBaseList.AddRange(Directory.GetFiles(fileList[i]));
                    fileList.InsertRange(i+1,addToBaseList);
                }
                i++;
                if (i > fileList.Count - 1) flag = false;
            }
        }
    }
}
