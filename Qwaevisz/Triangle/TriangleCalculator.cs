using System;

namespace Qwaevisz
{
    public class TriangleCalculator
    {
        private static void Main(string[] args)
        {
            Console.Write("Háromszög A oldala (cm): ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Háromszög B oldala (cm): ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Háromszög C oldala (cm): ");
            double sideC = Convert.ToDouble(Console.ReadLine());

            if ( sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA )
            {
                double district = sideA + sideB + sideC;
                double s = district / 2.0;
                double area = Math.Sqrt( s * (s - sideA) * (s - sideB) * (s - sideC));

                Console.WriteLine("A megadott háromszög kerülete " + district + " cm, területe pedig " + area + " cm2.");
            } else
            {
                Console.WriteLine("A megadott adatokból nem szerkeszthető háromszög.");
            }
        }
    }
}
