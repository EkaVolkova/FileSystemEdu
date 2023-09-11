using System;
using System.IO;

/// <summary>
/// 8.3.1. Напишите программу, которая выводит свой собственный исходный код в консоль.
/// 8.3.2 Сделайте так, чтобы ваша программа из задания 8.3.1 при каждом запуске добавляла в свой исходный код комментарий о времени последнего запуска.
/// </summary>
namespace WorkWithOwnFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\projects\skillfactory\FileSystemEdu\FileSystemEdu\WorkWithOwnFile\Program.cs";
            var fileInfo = new FileInfo(path); // Создаем объект класса FileInfo.
            
            using (StreamReader sr = fileInfo.OpenText())
            {
                string str = String.Empty;
                // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                while ((str = sr.ReadLine()) != null) 
                {
                    Console.WriteLine(str);
                }

            }
            using (var sw = fileInfo.AppendText())
            {
                sw.WriteLine(@"//Последний раз запущено " + DateTime.Now);
            }
        }
    }
}
//Последний раз запущено 11.09.2023 21:23:38
