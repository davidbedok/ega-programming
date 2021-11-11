using System;

namespace Qwaevisz
{
    public class AdvancedAverageCalculator
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Írja be a szerzett matematika jegyeket, 0 végjelig!");

            int grade = -1;
            int sum = 0;
            int numberOfGrades = 0;
            do
            {
                do
                {
                    Console.Write("Szerzett jegy: ");
                    grade = Convert.ToInt32(Console.ReadLine());
                } while (!(grade >= 0 && grade <= 5));
                if (grade != 0)
                {
                    sum += grade;
                    numberOfGrades++;
                }
            } while (grade != 0);

            double average = (double)sum / numberOfGrades;
            Console.WriteLine("A matematikai jegyek átlaga: " + average);
        }
    }
}
