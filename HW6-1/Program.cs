using System;
using System.Diagnostics;

namespace HW6_1
{
    //Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс.
    //Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса.
    //В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
    class Program
    {
        static void Main()
        {
            Process[] processes = Process.GetProcesses();
            bool flag = true;
            PrintProcesses(ref processes);
            while(flag)
            {
                Console.WriteLine("Введите имя процесса или его ID для выключения процесса");
                Console.WriteLine("Введите  -  Exit для выхода");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    flag = false;
                }
                else
                {
                    KillProcess(ref processes, input);
                    Console.Clear();
                    PrintProcesses(ref processes);
                }                 
            }
        }
        static void PrintProcesses(ref Process[] processes)
        {
            processes = Process.GetProcesses();
            foreach (Process proc in processes)
            {
                Console.WriteLine(proc.Id + "   " + proc.ProcessName);
            }
        }
        static void KillProcess(ref Process[] processes, string procName)
        {
            if (Int32.TryParse(procName, out int id))
            {
                foreach (Process proc in processes)
                {
                    if (proc.Id == id)
                    {
                        Console.WriteLine($"Вы уверены что хотите выключить процесс {proc.ProcessName} ?");
                        Console.Write("Введите Yes если уверены, No - если нет : ");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "yes")
                        {
                            proc.Kill();
                            return;
                        }
                        else return;
                    }
                }
            }
            else
            {
                foreach (Process proc in processes)
                {
                    if(proc.ProcessName.ToLower()==procName.ToLower())
                    {
                        Console.WriteLine($"Вы уверены что хотите выключить процесс {proc.ProcessName} ?");
                        Console.Write("Введите Yes если уверены, No - если нет : ");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "yes")
                        {
                            proc.Kill();
                            return;
                        }
                        else return;
                    }
                }
            }
            Console.WriteLine("Такого процесса не существует, Enter для продолжения");
            Console.ReadLine();
        }
    }
}
