namespace Qwaevisz
{
    public class Search
    {

        public static int LinearSearch( int[] data, int element )
        {
            int index = 0;
            while (index < data.Length && data[index] != element)
            {
                index++;
            }
            return index == data.Length ? -1 : index;
        }

        public static int BinarySearch(int[] orderedData, int element)
        {
            int startIndex = 0;
            int endIndex = orderedData.Length - 1;
            int result = -1;
            while (result == -1 && startIndex <= endIndex)
            {
                int centerIndex = (startIndex + endIndex) / 2;
                if (orderedData[centerIndex] == element)
                {
                    result = centerIndex;
                }
                else if (orderedData[centerIndex] < element)
                {
                    startIndex = centerIndex + 1;
                }
                else if (orderedData[centerIndex] > element)
                {
                    endIndex = centerIndex - 1;
                }
            }
            return result;
        }

    }
}
