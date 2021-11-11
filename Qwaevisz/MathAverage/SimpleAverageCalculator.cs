using System;

namespace Qwaevisz
{
    public class SimpleAverageCalculator
    {
        private static void Main2(string[] args)
        {
            Console.WriteLine("Írja be a szerzett matematika jegyeket, 0 végjelig!");

            int grade = -1;
            int sum = 0;
            int numberOfGrades = 0;

            Console.Write("Szerzett jegy: ");
            grade = Convert.ToInt32(Console.ReadLine());
            while ( grade != 0 )
            {
                sum += grade;
                numberOfGrades++;
                Console.Write("Szerzett jegy: ");
                grade = Convert.ToInt32(Console.ReadLine());
            }

            double average = (double)sum / numberOfGrades;
            // double average = Convert.ToDouble(sum) / numberOfGrades;
            Console.WriteLine("A matematikai jegyek átlaga: " + average);
        }
    }
}
