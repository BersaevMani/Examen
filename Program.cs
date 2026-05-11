using System;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();

            Console.WriteLine("Сколько тебе лет?");
            string age = Console.ReadLine();

            Console.WriteLine($"Привет, {name}! Тебе {age} лет.");

            Console.WriteLine("\nНажми любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}