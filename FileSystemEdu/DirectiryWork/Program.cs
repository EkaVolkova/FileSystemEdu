using System;
using System.IO;

/// <summary>
/// 8.2.1 Напишите метод, который считает количество файлов и папок в корне вашего диска и выводит итоговое количество объектов.
/// 8.2.2 Добавьте в метод из задания 8.2.1 создание новой директории в корне вашего диска, а после вновь выведите количество элементов уже после создания нового. 
/// Убедитесь, что их количество увеличилось, либо корректно вывелось сообщение об ошибке (если у вас нет прав на запись).
/// 8.2.3 Добавьте в задание 8.2.2 удаление вновь созданной директории и проверьте: теперь ваша программа не должна оставлять после себя следов!
/// </summary>
namespace DirectiryWork
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeAndRemoveNewDirectory();
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

        static void MakeNewDirectory(string name = @"C:\\NewFolder")
        {
            try
            {
                GetCountFilesAndDirectories();
                DirectoryInfo dirInfo = new DirectoryInfo(name);
                if (!dirInfo.Exists)
                    dirInfo.Create();


                GetCountFilesAndDirectories();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        static void MakeAndRemoveNewDirectory()
        {
            try
            {
                string dirName = @"C:\\NewFolder";
                MakeNewDirectory(dirName);
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                if (dirInfo.Exists)
                    dirInfo.Delete();


                GetCountFilesAndDirectories();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
