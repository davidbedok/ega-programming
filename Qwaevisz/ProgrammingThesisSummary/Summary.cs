using System;

namespace Qwaevisz
{
    public class Summary
    {

        private static void Main2(string[] args)
        {
            int size = 0;
            do
            {
                Console.Write("Elemek száma: ");
                size = Convert.ToInt32(Console.ReadLine());
            } while (size <= 0);
            int[] numbers = new int[size];
            Random generator = new Random();
            for ( int i = 0; i < size; i++ )
            {
                numbers[i] = generator.Next(100) - 50;
            }
            Console.WriteLine("A létrehozott tömb elemei:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0,4} ", numbers[i]);
                if ( (i+1) % 10 == 0 )
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            int sum = 0;
            for ( int i = 0; i < size; i++ )
            {
                sum += numbers[i];
            }
            Console.WriteLine("A tömb elemeinek összege: " + sum);
        }

    }
}
