using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace HW5_5
{
//    (*) Список задач(ToDo-list) :
//написать приложение для ввода списка задач;
//      задачу описать классом ToDo с полями Title и IsDone;
//      на старте, если есть файл tasks.json/xml/bin(выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
//      если задача выполнена, вывести перед её названием строку «[x]»;
//      вывести порядковый номер для каждой задачи;
//      при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
//      записать актуальный массив задач в файл tasks.json/xml/bin.

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа список задач");
            List<ToDo> tasks = new List<ToDo>();
            if (File.Exists("tasks.json")) OpenSave(ref tasks);
            PrintTasks(tasks);
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Введите exit для выхода");
                Console.WriteLine("Введите номер задачи чтобы сменить ее статус");
                Console.WriteLine("Или введите новую задачу");
                string str = Console.ReadLine();
                if (Int32.TryParse(str, out int i))
                {
                    if (i < tasks.Count)
                    {
                        tasks[i].ChangeIsDone();
                    }
                    else Console.WriteLine("Задачи с таким номером нет");
                }
                else if(str.ToLower()=="exit"){
                    flag = false;
                    Save(tasks);
                }
                else
                {
                    tasks.Add(new ToDo(str));
                }
                Console.Clear();
                Console.WriteLine("Программа список задач");
                PrintTasks(tasks);
            }
        }
        static void PrintTasks(List<ToDo> tasks)
        {
            for(int i=0;i<tasks.Count;i++)
            {
                if(tasks[i].IsDone == true)
                {
                    Console.WriteLine($"{i}   [X] {tasks[i].Title}");
                }
                else
                {
                    Console.WriteLine($"{i}   {tasks[i].Title}");
                }
            }
        }
        static void Save(List<ToDo> tasks)
        {
            string json = JsonSerializer.Serialize(tasks);
            File.WriteAllText("tasks.json", json);
        }
        static void OpenSave(ref List<ToDo> tasks)
        {
            string json = File.ReadAllText("tasks.json");
            tasks = JsonSerializer.Deserialize<List<ToDo>>(json);
        }
    }
}
