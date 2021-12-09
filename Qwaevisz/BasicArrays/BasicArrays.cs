using System;

namespace Qwaevisz
{
    public class BasicArrays
    {
        private static void Main(string[] args)
        {
            int[] grades;
            grades = new int[5];
            grades[0] = 42;
            grades[1] = 30;
            grades[2] = 25;
            grades[3] = 19;
            grades[4] = 7;
            Console.WriteLine("A tömb 3. eleme: " + grades[3]);

            int[] numbers;
            numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + ". szám: ");
                string input = Console.ReadLine();
                numbers[i] = Convert.ToInt32(input);
            }

            int sum = 0;
            for ( int i = 0; i < 5; i++ )
            {
                sum += numbers[i];
            }
            double average = sum / 5;
            Console.WriteLine("A számok átlaga: " + average);

            double minDiscrepancy = Math.Abs(average - numbers[0]);
            for (int i = 1; i < 5; i++)
            {
                double currentDiscrepancy = Math.Abs(average - numbers[i]);
                if (currentDiscrepancy < minDiscrepancy )
                {
                    minDiscrepancy = currentDiscrepancy;
                }
            }
            Console.WriteLine("Az átlagtól való legkisebb eltérés: " + minDiscrepancy);

            int[] ages = { 8, 14, 26, 67 };
            double[] values = { 3.14, 5, 8.29 };

            int[] nums;
            nums = new int[]{ 8, 14, 26, 67 };

            double[] vals;
            vals = new double[]{ 3.14, 5, 8.29 };

        }
    }
}
