using System;

namespace Qwaevisz
{
    public class Assortment
    {

        public static int[] AssortPositiveNumbers( int[] data )
        {
            int numberOfPositive = CountPositiveNumbers(data);
            int[] result = new int[numberOfPositive];
            int index = 0;
            for ( int i = 0; i < data.Length; i++ )
            {
                if ( data[i] > 0 )
                {
                    result[index++] = data[i];
                }
            }
            return result;
        }

        public static int[] AssortPositiveNumbersMod(int[] data)
        {
            int[] result = new int[CountPositiveNumbers(data)];
            int index = 0;
            int i = 0;
            while (index != result.Length)
            {
                if (data[i] > 0)
                {
                    result[index++] = data[i];
                }
                i++;
            }
            return result;
        }

        private static int CountPositiveNumbers(int[] data)
        {
            int result = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > 0)
                {
                    result++;
                }
            }
            return result;
        }

    }
}
