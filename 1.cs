using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введiть кiлькiсть чисел (N): ");
        int N = int.Parse(Console.ReadLine());
        Random rand = new Random();

        // Створення колекції з N випадкових чисел в межах [-5; 5]
        List<int> numbers = Enumerable.Range(0, N).Select(_ => rand.Next(-5, 6)).ToList();
        Console.WriteLine("Оригiнальна колекцiя: " + string.Join(", ", numbers));

        // Знаходження мінімального значення
        int minValue = numbers.Min();

        // Видалення всіх мінімальних значень
        numbers.RemoveAll(x => x == minValue);
        Console.WriteLine("Колекцiя пiсля видалення мiнiмальних чисел: " + string.Join(", ", numbers));
    }
}