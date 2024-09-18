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

        // Створення двох колекцій з N випадкових чисел в межах [-10; 10]
        List<int> list1 = Enumerable.Range(0, N).Select(_ => rand.Next(-10, 11)).ToList();
        List<int> list2 = Enumerable.Range(0, N).Select(_ => rand.Next(-10, 11)).ToList();

        Console.WriteLine("Перша колекцiя: " + string.Join(", ", list1));
        Console.WriteLine("Друга колекцiя: " + string.Join(", ", list2));

        // Формування третьої колекції
        List<int> list3 = list1.Zip(list2, (a, b) => a == b ? 1 : 0).ToList();

        Console.WriteLine("Третя колекцiя: " + string.Join(", ", list3));
    }
}