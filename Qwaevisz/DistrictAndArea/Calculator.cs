using System;

namespace DistrictAndArea
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

            Console.WriteLine("A megadott téglalap kerülete " + district + " cm, területe pedig " + area + " cm2.");
        }
    }
}
