using System;
using System.Collections.Generic;
using System.IO;

namespace HW5_4
{
    //Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
    class Program
    {
        static void Main()
        {
            Console.Write("Введите полное название директории : ");
            string dir = Console.ReadLine();
            string tab = "-";
            string textFile = "recursFolders.txt";
            string textFile1 = "Folders.txt";
            List<string> recursionFileList = new List<string>();
            List<string> fileList = new List<string>();
            if (Directory.Exists(dir))
            {
                recursionFileList.Add(dir);
                WriteFilesRecursion(dir, recursionFileList, tab);
                WriteFiles(dir,fileList);
                File.WriteAllLines(textFile, recursionFileList);
                File.WriteAllLines(textFile1, fileList);
            }
            else
            {
                Console.WriteLine("Такой директории не существует");
            }
        }
        static void WriteFiles(string dirName, List<string> fileList)
        {
            fileList.AddRange(Directory.GetFileSystemEntries(dirName, "*", SearchOption.AllDirectories));
        }
        static void WriteFilesRecursion(string dirName, List<string> recursionFileList, string tab)
        {
            string[] dirFolder=dirName.Split('\\');
            recursionFileList.Add($"{tab}{dirFolder[dirFolder.Length-1]}");
            tab += "-";
            string[] folders = Directory.GetDirectories(dirName);
            string[] files = Directory.GetFiles(dirName);
            if(folders.Length>0)
            {
                for (int i = 0; i < folders.Length; i++) WriteFilesRecursion(folders[i], recursionFileList, tab);
            }
            if(files.Length>0)
            {

                for (int i = 0; i < files.Length; i++) recursionFileList.Add($"{tab}{Path.GetFileName(files[i])}");
            }
        }
    }
}
