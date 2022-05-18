using System;

namespace Qwaevisz
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            int[] mathGrades = GenerateGradesForYear(random, 10);
            int[] englishGrades = GenerateGradesForYear(random, 10);
            PrintGrades("matematika", mathGrades);
            PrintGrades("angol", englishGrades);

            Console.WriteLine("A legsikeresebb matematika havi átlag: " + GetMostSuccessfulMonthlyAverage(mathGrades));
            Console.WriteLine("A legsikeresebb angol havi átlag: " + GetMostSuccessfulMonthlyAverage(englishGrades));
        }

        private static double GetMostSuccessfulMonthlyAverage( int[] grades )
        {
            int index = 0;
            int sum = 0;
            int counter = 0;
            double maxAverage = 0;
            int monthIndex = 1;
            while (index < grades.Length)
            {
                if (grades[index] != 0 )
                {
                    sum += grades[index];
                    counter++;
                } else
                {
                    double average = (double)sum / counter;
                    Console.WriteLine(monthIndex++ + ". havi átlag: " + average);
                    if ( average > maxAverage )
                    {
                        maxAverage = average;
                    }
                    sum = 0;
                    counter = 0;
                }
                index++;
            }
            return maxAverage;
        }

        private static int[] GenerateGradesForYear( Random generator, int numberOfMonths)
        {
            int[] numberOfGradesInYear = new int[numberOfMonths];
            int sum = 0;
            for (int i = 0; i < numberOfMonths; i++)
            {
                numberOfGradesInYear[i] = generator.Next(0, 8);
                sum += numberOfGradesInYear[i];
            }

            int[] result = new int[sum + numberOfMonths];
            int index = 0;
            for (int i = 0; i < numberOfMonths; i++)
            {
                for (int j = 0; j < numberOfGradesInYear[i]; j++)
                {
                    result[index++] = generator.Next(1, 6);
                }
                result[index++] = 0;
            }
            return result;
        }

        public static void PrintGrades(string subject, int[] data)
        {
            Console.WriteLine("A szerzett jegyek " + subject + " tantárgyból:");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("{0,4} ", data[i]);
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

    }
}
