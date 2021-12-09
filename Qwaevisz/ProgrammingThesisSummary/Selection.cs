using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingThesisSummary
{
    public class Selection
    {

        private static void Main2(string[] args)
        {
            int size = GetNumberSize();
            int[] numbers = GenerateNumbers(size);
            PrintNumbers(numbers);

            if (size > 0) {
                /*
                int max = numbers[0];
                for (int i = 1; i < size; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];    
                    }
                }
                */
                Console.WriteLine("A sorozat legnagyobb eleme: " + GetMaxNumber(numbers));
            } else
            {
                Console.WriteLine("A sorozat üres, nem értelmezett a legnagyobb elem.");
            }
            
        }

        private static int GetMaxNumber( int[] data )
        {
            int max = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > max)
                {
                    max = data[i];
                }
            }
            return max;
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

        private static int[] GenerateNumbers(int length)
        {
            int[] result = new int[length];
            Random generator = new Random();
            for (int i = 0; i < length; i++)
            {
                result[i] = generator.Next(100) - 50;
            }
            return result;
        }

        private static void PrintNumbers(int[] data)
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

    }
}
