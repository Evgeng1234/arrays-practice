using System;
namespace Task4
{
   class Program
   {
     static void Main()
     {
int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введите элемент [{i}]: ");
                try
                {
                    numbers[i] = int.Parse(Console.ReadLine()!);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                    i--;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                    i--;
                }
            }

            while (true)
            {
                Console.Write("Введите индекс для вывода (0-4): ");
                try
                {
                    int index = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Элемент [{index}]: {numbers[index]}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Ошибка: Индекс вне границ массива.");
                }
            }
     }
   }
}
