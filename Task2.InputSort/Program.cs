using System;
namespace Task2
{
   class Program
   {
     static void Main()
     {
int n = 0;

            while (n <= 0)
            {
                Console.Write("Введите количество элементов: ");
                int.TryParse(Console.ReadLine(), out n);
            }

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент [{i}]: ");
                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    i--;
                }
            }

            Console.WriteLine();

            Console.WriteLine($"Исходный массив: {string.Join(", ", numbers)}");

            int[] reversed = new int[n];
            for (int i = 0; i < n; i++)
            {
                reversed[i] = numbers[n - 1 - i];
            }
            Console.WriteLine($"Обратный порядок: {string.Join(", ", reversed)}");

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < n; i++)
            {
                if (numbers[i] < min) min = numbers[i];
                if (numbers[i] > max) max = numbers[i];
            }

            Array.Sort(numbers);

            Console.WriteLine($"Отсортированный: {string.Join(", ", numbers)}");
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");
     }
   }
}
