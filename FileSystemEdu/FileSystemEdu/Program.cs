using System;

/// <summary>
/// Придумайте простой класс, который будет предоставлять информацию об установленном в системе диске. 
/// Нужны свойства, чтобы хранить: имя диска, объём, свободное место. 
/// Свойства инициализируются при создании нового объекта в методе-конструкторе.
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
        public Disk(string diskName, double diskSize, double diskFreeSize)
        {
            Name = diskName;
            TotalSize = diskSize;
            FreeSize = diskFreeSize;
        }
    }

}
