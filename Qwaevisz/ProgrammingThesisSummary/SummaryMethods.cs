using System;

namespace Qwaevisz
{
    public class SummaryMethods
    {
        private static void Main2(string[] args)
        {
            int size = GetNumberSize();
            int[] numbers = GenerateNumbers(size);
            PrintNumbers(numbers);
            Console.WriteLine("A tömb elemeinek összege: " + Summary(numbers));
        }

        private static int GetNumberSize()
        {
            int result = 0;
            do
            {
                Console.Write("Elemek száma: ");
                result = Convert.ToInt32(Console.ReadLine());
            } while (result <= 0);
            return result;
        }

        private static int[] GenerateNumbers( int length )
        {
            int[] result = new int[length];
            Random generator = new Random();
            for (int i = 0; i < length; i++)
            {
                result[i] = generator.Next(100) - 50;
            }
            return result;
        }

        private static void PrintNumbers( int[] data )
        {
            Console.WriteLine("A létrehozott tömb elemei:");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("{0,4} ", data[i]);
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        private static int Summary( int[] data )
        {
            int sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }
            return sum;
        }

    }
}
