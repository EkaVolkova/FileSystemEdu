using System;
using System.IO;

/// <summary>
/// Напишите программу, которая выводит свой собственный исходный код в консоль.
/// </summary>
namespace WorkWithOwnFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\projects\skillfactory\FileSystemEdu\FileSystemEdu\WorkWithOwnFile\Program.cs";
            using (StreamReader sr = File.OpenText(path))
            {
                string str = String.Empty;
                // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                while ((str = sr.ReadLine()) != null) 
                {
                    Console.WriteLine(str);
                }

            }
        }
    }
}
