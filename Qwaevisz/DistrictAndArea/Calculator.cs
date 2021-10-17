using System;

namespace Qwaevisz
{
    public class Calculator
    {
        private static void Main(string[] args)
        {
            Console.Write("Téglalap A oldala (cm): ");
            string sideAText = Console.ReadLine();
            Console.Write("Téglalap B oldala (cm): ");
            string sideBTest = Console.ReadLine();

            int sideA = Convert.ToInt32(sideAText);
            int sideB = Convert.ToInt32(sideBTest);

            int district = 2 * sideA + 2 * sideB;
            int area = sideA * sideB;

            if ( sideA == sideB )
            {
                Console.WriteLine("A megadott négyzet kerülete " + district + " cm, területe pedig " + area + " cm2.");
            } else
            {
                Console.WriteLine("A megadott téglalap kerülete " + district + " cm, területe pedig " + area + " cm2.");
            }

            string type = sideA == sideB ? "négyzet" : "téglalap";
            Console.WriteLine("A megadott "+ type + " kerülete " + district + " cm, területe pedig " + area + " cm2.");

            Console.WriteLine("A megadott " + 
                (sideA == sideB ? "négyzet" : "téglalap") + 
                " kerülete " + (2 * sideA + 2 * sideB) + 
                " cm, területe pedig " + (sideA * sideB) + " cm2.");
        }
    }
}
