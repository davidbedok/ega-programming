using System;
using System.Collections.Generic;
using System.Text;

namespace Qwaevisz
{
    public class Utility
    {

        public static int GetNumberSize()
        {
            int result = 0;
            do
            {
                Console.Write("Elemek száma: ");
                result = Convert.ToInt32(Console.ReadLine());
            } while (result <= 0);
            return result;
        }

        public static int[] GenerateNumbers(int length)
        {
            int[] result = new int[length];
            Random generator = new Random();
            for (int i = 0; i < length; i++)
            {
                result[i] = generator.Next(100) - 50;
            }
            return result;
        }

        public static void PrintNumbers(string title, int[] data)
        {
            Console.WriteLine(title + ":");
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
