using System;
using System.IO;

/// <summary>
/// 8.4.1. На рабочем столе лежит бинарный файл BinaryFile.bin. В нём записана дата создания и имя операционной системы, на которой он был создан (формат данных — строка).
/// Напишите программу, которая считает из него данные и позволит вам ответить на следующие вопросы:
/// Когда файл был создан?
/// На какой операционной системе создан файл?
/// 8.4.2 Запишите в файл из предыдущего задания информацию о доступе к нему с вашей машины. 
/// </summary>
namespace BinaryFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ekate\Desktop\BinaryFile.bin";
            using (var binaryReader = new BinaryReader(new FileStream(path, FileMode.Open)))
            {
                Console.WriteLine(binaryReader.ReadString());
            }
            using (var binaryWriter = new BinaryWriter(new FileStream(path, FileMode.Append)))
            {
                binaryWriter.Write("Файл изменен " + DateTime.Now + " на компьютере " + Environment.OSVersion);
            }
        }
    }
}
