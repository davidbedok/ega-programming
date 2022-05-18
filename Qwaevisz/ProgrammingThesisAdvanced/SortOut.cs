using System;
using System.Collections.Generic;
using System.Text;

namespace Qwaevisz
{
    public class SortOut
    {

        public static int[][] SortOutNumbersByPositivity(int[] data)
        {
            int numberOfNonNegative = CountNonNegativeNumbers(data);
            int[][] result = new int[2][];
            result[0] = new int[numberOfNonNegative];
            result[1] = new int[data.Length - numberOfNonNegative];
            int indexOfPos = 0;
            int indexOfNeg = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 0)
                {
                    result[0][indexOfPos++] = data[i];
                } else
                {
                    result[1][indexOfNeg++] = data[i];
                }
            }
            return result;
        }

        private static int CountNonNegativeNumbers(int[] data)
        {
            int result = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 0)
                {
                    result++;
                }
            }
            return result;
        }

    }
}
