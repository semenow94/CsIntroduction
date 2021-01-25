using System;

namespace HW3_3
{
    //Написать программу, выводящую введенную пользователем строку в обратном порядке(olleH вместо Hello).
    class Program
    {
        static void Main()
        {
            Console.Write("Введите любое слово :");
            string word = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ваше слово наоборот : ");
            RemakeWord(word);
        }
        static void RemakeWord(string word)
        {
            for (int i = word.Length - 1; i >= 0; i--) Console.Write(word[i]+" ");
        }
    }
}
