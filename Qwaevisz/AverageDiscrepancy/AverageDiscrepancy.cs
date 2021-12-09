using System;

namespace Qwaevisz
{
    public class AverageDiscrepancy
    {
        private static void Main(string[] args)
        {
            int minimum = Int32.MaxValue;
            int maximum = Int32.MinValue;
            for ( int i = 0; i < 7; i++)
            {
                Console.Write( (i + 1) + ". szám: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if ( num < minimum )
                {
                    minimum = num;
                }
                if ( num > maximum )
                {
                    maximum = num;
                }
            }
            Console.WriteLine("A legkisebb szám a megadottak közül: " + minimum);
            Console.WriteLine("A legnagyobb szám a megadottak közül: " + maximum);

            // -------------------------------------

            Console.Write("1. szám: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int min = num1;
            int max = num1;
            
            Console.Write("2. szám: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if ( min > num2 )
            {
                min = num2;
            }
            if ( max < num2 )
            {
                max = num2;
            }
            
            Console.Write("3. szám: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (min > num3)
            {
                min = num3;
            }
            if (max < num3)
            {
                max = num3;
            }

            Console.Write("4. szám: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            if (min > num4)
            {
                min = num4;
            }
            if (max < num4)
            {
                max = num4;
            }

            Console.Write("5. szám: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            if (min > num5)
            {
                min = num5;
            }
            if (max < num5)
            {
                max = num5;
            }

            Console.Write("6. szám: ");
            int num6 = Convert.ToInt32(Console.ReadLine());
            if (min > num6)
            {
                min = num6;
            }
            if (max < num6)
            {
                max = num6;
            }

            Console.Write("7. szám: ");
            int num7 = Convert.ToInt32(Console.ReadLine());
            if (min > num7)
            {
                min = num7;
            }
            if (max < num7)
            {
                max = num7;
            }

            Console.WriteLine("A legkisebb szám a megadottak közül: " + min);
            Console.WriteLine("A legnagyobb szám a megadottak közül: " + max);

            double average = (num1 + num2 + num3 + num4 + num5 + num6 + num7) / 7.0;
            Console.WriteLine("A számok átlaga: " + average);

            double tmp = Math.Abs(num1 - average);
            double minDiscrepancy = tmp;
            tmp = Math.Abs(num2 - average);
            if ( tmp < minDiscrepancy )
            {
                minDiscrepancy = tmp;
            }
            tmp = Math.Abs(num3 - average);
            if (tmp < minDiscrepancy)
            {
                minDiscrepancy = tmp;
            }
            tmp = Math.Abs(num4 - average);
            if (tmp < minDiscrepancy)
            {
                minDiscrepancy = tmp;
            }
            tmp = Math.Abs(num5 - average);
            if (tmp < minDiscrepancy)
            {
                minDiscrepancy = tmp;
            }
            tmp = Math.Abs(num6 - average);
            if (tmp < minDiscrepancy)
            {
                minDiscrepancy = tmp;
            }
            tmp = Math.Abs(num7 - average);
            if (tmp < minDiscrepancy)
            {
                minDiscrepancy = tmp;
            }
            Console.WriteLine("Az átlagtól való legkisebb eltérés: " + minDiscrepancy);
        }
    }
}
