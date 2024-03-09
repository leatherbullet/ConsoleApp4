using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int size = 30;
            int minValue = 0;
            int maxValue = 10;

            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue,maxValue);
                
                Console.Write(numbers[i] + " ");
            }

            Console.SetCursorPosition(0,1);
            Console.WriteLine("локальные максимумы");

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
