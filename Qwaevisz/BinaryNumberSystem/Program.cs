using System;

namespace BinaryNumberSystem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double number = 0.1;

            int index = 0;
            while ( number != 10 )
            {
                if ( index % 10 == 0 )
                {
                    Console.WriteLine(index + ". ciklus: " + number);
                }
                number += 0.1;
                index++;
                if ( index == 1000 )
                {
                    break;
                }
            }

            Console.WriteLine(index + ". utolsó ciklus: " + number);
        }
    }
}
