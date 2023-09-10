using System;
using System.Collections.Generic;

/// <summary>
/// 8.1.4
/// Придумайте простой класс, который будет предоставлять информацию об установленном в системе диске. 
/// Нужны свойства, чтобы хранить: имя диска, объём, свободное место. 
/// Свойства инициализируются при создании нового объекта в методе-конструкторе.
/// 
/// 8.1.5 Нужно создать папки (директории) для сортировки файлов. 
/// Добавьте метод для создания новой директории на диске. Подумайте, какую коллекцию использовать для хранения созданных директорий.
/// Пусть директория (папка) будет представлена классом: 
///     public class Folder
///     {
///         public List<string> Files { get; set; } = new List<string>();
///     }
/// Реализация метода: Принимает на вход имя папки, добавляет её в коллекцию папок, выводит информацию о том, что папка создана. 
/// </summary>
namespace FileSystemEdu
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Disk
    {
        public string Name { get; }
        public double TotalSize { get; }
        public double FreeSize { get; private set; }
        public Dictionary<string, Folder> Directories = new Dictionary<string, Folder>();
        public Disk(string diskName, double diskSize, double diskFreeSize)
        {
            Name = diskName;
            TotalSize = diskSize;
            FreeSize = diskFreeSize;
        }
        public void MakeNewFolder(string nameFolder)
        {
            
            Directories.Add(nameFolder, new Folder());
            Console.WriteLine("Directory {0} created", nameFolder);

        }
    }
    public class Folder
    {
        public List<string> Files { get; set; } = new List<string>();
        

    }

}
