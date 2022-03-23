using System;

namespace UserProfileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату рождения: ");
            var birthdate = Console.ReadLine();

            Console.Write($"Ваше имя: {name}, возраст: {age}, дата рождения: {birthdate}");

            Console.ReadLine();
        }
    }
}
