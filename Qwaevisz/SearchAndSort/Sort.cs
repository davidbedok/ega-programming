using System;
using System.Collections.Generic;
using System.Text;

namespace Qwaevisz
{
    public class Sort
    {

        public static void BubbleSort( int[] data )
        {
            for ( int i = 0; i < (data.Length - 1); i++)
            {
                for ( int j = i; j < data.Length; j++ )
                {
                    if ( data[i] > data[j] )
                    {
                        Swap(data, i, j);
                    }
                }
            }
        }

        private static void Swap( int[] data, int indexA, int indexB )
        {
            int tmp = data[indexA];
            data[indexA] = data[indexB];
            data[indexB] = tmp;
        }

        public static void MinimumSelectionSort(int[] data)
        {
            for (int i = 0; i < (data.Length - 1); i++)
            {
                int min = data[i];
                int minIndex = i;
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < min)
                    {
                        min = data[j];
                        minIndex = j;
                    }
                }
                Swap(data, i, minIndex);
            }
        }

    }
}
