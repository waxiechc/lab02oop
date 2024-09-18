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

        // Створення колекції з N випадкових чисел в межах [1; 99]
        List<int> numbers = Enumerable.Range(0, N).Select(_ => rand.Next(1, 100)).ToList();
        Console.WriteLine("Оригiнальна колекцiя: " + string.Join(", ", numbers));

        // Знаходження останнього непарного числа з парною першою цифрою
        int indexToInsert = -1;
        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            if (numbers[i] % 2 != 0 && (numbers[i] / 10) % 2 == 0)
            {
                indexToInsert = i;
                break;
            }
        }

        // Вставка числа 0 перед цим числом
        if (indexToInsert != -1)
        {
            numbers.Insert(indexToInsert, 0);
        }
        Console.WriteLine("Колекцiя пiсля вставки: " + string.Join(", ", numbers));
    }
}
