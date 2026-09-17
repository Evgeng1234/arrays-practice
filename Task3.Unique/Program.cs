using System;
namespace Task3
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

            Console.Write("Исходный массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i]);
                if (i < n - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            Console.Write("Уникальные элементы: ");
            bool first = true;

            for (int i = 0; i < n; i++)
            {
                int count = 0;

                for (int j = 0; j < n; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    if (!first)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(numbers[i]);
                    first = false;
                }
            }
            Console.WriteLine();
     }
   }
}
