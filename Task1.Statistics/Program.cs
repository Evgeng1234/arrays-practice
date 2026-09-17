using System;
namespace Task1
{
   class Program
   {
     static void Main()
     {
       Random random = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }
            Console.WriteLine("Массив: " + string.Join(", ", numbers));
            long sum = 0;             
            double product = 1;       
            int evenCount = 0;                  
            foreach (int num in numbers)
            {
                sum = sum + num;          
                product = product * num;  

                
                if (num % 2 == 0)
                {
                    evenCount++;          
                }
            }           
            double average = (double)sum / numbers.Length;           
            int greaterThanAvgCount = 0;
            foreach (int num in numbers)
            {
                if (num > average)
                {
                    greaterThanAvgCount++;
                }
            }

          
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Произведение: " + product);
            Console.WriteLine("Чётных чисел: " + evenCount);
            Console.WriteLine("Больше среднего (" + average + "): " + greaterThanAvgCount);

     }
   }
}
