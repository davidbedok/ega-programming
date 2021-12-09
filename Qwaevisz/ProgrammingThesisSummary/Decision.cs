using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingThesisSummary
{
    public class Decision
    {

        private static void Main2(string[] args)
        {
            int size = GetNumberSize();
            int[] numbers = GenerateNumbers(size);
            PrintNumbers(numbers);

            /*
            int i = 0;
            while ( i < size && numbers[i] != 0 )
            {
                i++;
            }
            bool hasZero = i < size;
            Console.WriteLine("Ciklusmagok futásának száma: " + i);
            */
            Console.WriteLine("Van a sorozatban nulla? " + HasZero(numbers));
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
                result[i] = generator.Next(10) - 5;
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
        private static bool HasZero(int[] data)
        {
            int i = 0;
            while (i < data.Length && data[i] != 0)
            {
                i++;
            }
            return i < data.Length;
        }

    }
}
