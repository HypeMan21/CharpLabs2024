using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть три цілі числа:");
        int[] numbers = new int[3];

        // Зчитування трьох цілих чисел
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Числа, які належать інтервалу [1, 18]:");

        // Вибір чисел, які належать інтервалу [1, 18]
        foreach (int num in numbers)
        {
            if (num >= 1 && num <= 18)
            {
                Console.WriteLine(num);
            }
        }
    }
}
