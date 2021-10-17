using System;

namespace Qwaevisz
{
    public class ConditionalStatement
    {
        private static void Main(string[] args)
        {
            Console.Write("A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if ( a >= b )
            {
                Console.WriteLine("Az '" + a + "' nagyobb vagy egyenlő mint '" + b + "'.");
            } else
            {
                Console.WriteLine("Az '" + a + "' kisebb mint '" + b + "'.");
            }
        }
    }
}
