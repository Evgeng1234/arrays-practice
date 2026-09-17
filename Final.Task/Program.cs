// Вариант 2. Палиндром
using System;

namespace Final.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите массив: ");
            string input = Console.ReadLine()!;

            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }

            bool isPalindrome = true;
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                if (numbers[i] != numbers[numbers.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine("Массив — палиндром");
            }
            else
            {
                Console.WriteLine("Массив — не палиндром");
            }
        }
    }
}