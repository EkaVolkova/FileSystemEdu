using System;
using System.IO;
/// <summary>
/// Задание 8.2.4 Создайте на рабочем столе папку testFolder. 
/// Напишите метод, с помощью которого можно будет переместить её в корзину. 
/// </summary>
namespace DeliteFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ekate\Desktop";
            string folder = @"\TestFolder";
            Console.WriteLine("До добавления папки");
            GetCountDirectories(path);
            CreateFolder(path + folder);
            Console.WriteLine("После появления папки");
            GetCountDirectories(path);
            DeliteFolder(path + folder);
            Console.WriteLine("После удаления папки");
            GetCountDirectories(path);


        }
        static void GetCountDirectories(string dir)
        {
            try
            {
                Console.WriteLine("Количество  директорий: " + Directory.GetDirectories(dir).Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        static void CreateFolder(string dir)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(dir);
                if (!directoryInfo.Exists)
                    directoryInfo.Create();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void DeliteFolder(string dir)
        {
            try
            {
                string folder = dir.Split('\\')[dir.Split('\\').Length - 1];
                DirectoryInfo directoryInfo = new DirectoryInfo(dir);
                if (directoryInfo.Exists)
                    directoryInfo.MoveTo(@"C:\$Recycle.Bin\" + folder);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
