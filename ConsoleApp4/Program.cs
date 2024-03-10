using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int size;
            int minValue = 0;
            int maxValue = 10;
            int penultimateIndex = 2;
            
            Console.WriteLine("введите размер массива:");
            size = Convert.ToInt32(Console.ReadLine());
            
            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue,maxValue);
                
                Console.Write(numbers[i] + " ");
            }

            Console.SetCursorPosition(0,3);
            Console.WriteLine("локальные максимумы");

            if (numbers[0] > numbers[1])
            {
               Console.WriteLine(numbers[0]);
            }
            
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            if (numbers[size - 1] > numbers[size - penultimateIndex])
            {
               Console.WriteLine(numbers[size - 1]);  
            }
        }
    }
}
