using System;
using System.IO;

/// <summary>
/// 8.2.1 Напишите метод, который считает количество файлов и папок в корне вашего диска и выводит итоговое количество объектов.
/// 
/// </summary>
namespace DirectiryWork
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCountFilesAndDirectories();
        }
        static void GetCountFilesAndDirectories()
        {
            try
            {
                string dirName = @"C:\\";
                string[] dirs = Directory.GetDirectories(dirName);
                string[] files = Directory.GetFiles(dirName);
                int countFilesAndDirectories = dirs.Length + files.Length;
                Console.WriteLine("Количество файлов и директорий: " + countFilesAndDirectories);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

        }
    }
}
