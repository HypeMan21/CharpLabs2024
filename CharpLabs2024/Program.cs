using System;

class Program
{
    static void Main(string[] args)
    {
        // Task 1
        Console.WriteLine("Task 1: Введіть три цілі числа:");
        int[] numbers = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Числа, які належать інтервалу [1, 18]:");
        foreach (int num in numbers)
        {
            if (num >= 1 && num <= 18)
            {
                Console.WriteLine(num);
            }
        }

        // Task 2
        Console.WriteLine("\nTask 2: Генерація масиву з випадковими значеннями та пошук мінімального та максимального значень:");
        int[] array = GenerateArray(18); // Генеруємо масив з 18 елементів

        int min = array[0];
        int max = array[0];
        foreach (int num in array)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }

        Console.WriteLine("Масив:");
        PrintArray(array);
        Console.WriteLine($"Мінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");

        // Task 3
        Console.WriteLine("\nTask 3: Генерація масиву X з випадковими значеннями та обчислення масиву Y:");
        int[] X = GenerateArray(18); // Генеруємо масив X з 18 елементів
        int M;

        Console.Write("Введіть число M: ");
        while (!int.TryParse(Console.ReadLine(), out M))
        {
            Console.WriteLine("Введено некоректне значення для M. Спробуйте ще раз.");
            Console.Write("Введіть число M: ");
        }

        int[] Y = new int[X.Length];
        int countY = 0;

        foreach (int num in X)
        {
            if (Math.Abs(num) > M)
            {
                Y[countY] = num;
                countY++;
            }
        }

        Console.WriteLine($"Число M: {M}");
        Console.WriteLine("Масив X:");
        PrintArray(X);
        Console.WriteLine("Масив Y:");
        PrintArray(Y, countY); // Виводимо лише перші countY елементів масиву Y
    }

    // Task 2: Генерація масиву з випадковими значеннями
    static int[] GenerateArray(int length)
    {
        Random rand = new Random();
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = rand.Next(-100, 101); // Випадкові числа від -100 до 100
        }
        return array;
    }

    // Task 2: Виведення масива на екран
    static void PrintArray(int[] array, int length = -1)
    {
        if (length == -1)
            length = array.Length;

        for (int i = 0; i < length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

