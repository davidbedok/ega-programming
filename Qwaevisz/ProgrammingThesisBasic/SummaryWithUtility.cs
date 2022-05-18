using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingThesisSummary
{
    public class SummaryWithUtility
    {

        private static void Main2(string[] args)
        {
            int size = Utility.GetNumberSize();
            int[] numbers = Utility.GenerateNumbers(size);
            Utility.PrintNumbers(numbers);
            Console.WriteLine("A tömb elemeinek összege: " + Summary(numbers));
        }

        private static int Summary(int[] data)
        {
            int sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }
            return sum;
        }

    }
}
