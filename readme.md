# Задание 1 — Приветствие

Фамилия Имя: Берсаев Мани  
Вариант: 1

## Задание
Запросить у пользователя имя и возраст, вывести текст:  
«Привет, [Имя]! Тебе [Возраст] лет.»

## Код решения 

`csharp
using System;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как тебя зовут? ");
            string name = Console.ReadLine();

            Console.Write("Сколько тебе лет? ");
            string age = Console.ReadLine();

            Console.WriteLine($"Привет, {name}! Тебе {age} лет.");

            Console.WriteLine("\nНажми любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

<img src="1.png" alt="Результат выполнения">