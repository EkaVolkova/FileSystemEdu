using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

/// <summary>
/// 8.4.3. Дан класс Contact. Доработайте его и сериализуйте в бинарный формат
/// </summary>
namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var contact = new Contact("Tom", 9876534567, "tom@gmail.com");
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (var fs = new FileStream("mycontact.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, contact);
            }
        }
    }
    [Serializable]
    class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
