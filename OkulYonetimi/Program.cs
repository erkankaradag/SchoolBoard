
using System;

namespace SchoolBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Person teacher1 = new Person
            {
                Name = "Metin",
                Surname = "Kaya",
                DateBirth = new DateTime(1990, 5, 15)
            };

            Person teacher2 = new Person
            {
                Name = "Ali",
                Surname = "Deniz",
                DateBirth = new DateTime(1992, 3, 7)
            };

            Person teacher3 = new Person
            {
                Name = "Ömer",
                Surname = "Kara",
                DateBirth = new DateTime(1995, 7, 29)
            };

            Console.WriteLine("--------------Öğretmen Listesi-----------------\n");

            PrintPersonDetails(teacher1);
            Console.WriteLine("---------------------");
            PrintPersonDetails(teacher2);
            Console.WriteLine("---------------------");
            PrintPersonDetails(teacher3);

            Person student1 = new Person
            {
                Name = "Ahmet",
                Surname = "Can",
                DateBirth = new DateTime(2005, 2, 28)
            };
            Person student2 = new Person
            {
                Name = "Enes",
                Surname = "Tunç",
                DateBirth = new DateTime(2003, 1, 28)
            };
            Person student3 = new Person
            {
                Name = "Emir",
                Surname = "Bilir",
                DateBirth = new DateTime(2001, 1, 18)
            };

            Console.WriteLine("\n--------------Öğrenci Listesi-----------------\n");
            PrintPersonDetails(student1);
            Console.WriteLine("---------------------");
            PrintPersonDetails(student2);
            Console.WriteLine("---------------------");
            PrintPersonDetails(student3);
        }

        static void PrintPersonDetails(Person person)
        {
            Console.WriteLine($"Adı: {person.Name}");
            Console.WriteLine($"Soyadı: {person.Surname}");
            Console.WriteLine($"Doğum Tarihi: {person.DateBirth:dd-MM-yyyy}");
        }
    }
}