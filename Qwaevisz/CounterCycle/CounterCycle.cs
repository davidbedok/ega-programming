using System;

namespace Qwaevisz
{
    public class CounterCycle
    {
        private static void Main(string[] args)
        {
            Console.Write("A büntetésből leírandó szöveg: ");
            string penaltyText = Console.ReadLine();
            Console.Write("Hányszor kell leírni a büntetést?: ");
            int counter = Convert.ToInt32(Console.ReadLine());
            int index;
            for (index = 1; index <= counter; index++ )
            {
                Console.WriteLine(index + ". " + penaltyText);
            }
        }

    }
}
