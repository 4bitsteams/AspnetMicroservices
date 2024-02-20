namespace ProblemSolvingDSA.Sorting
{
    public class Sorting
    {
        public static void BubbleSort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }
        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;
            int tempValue = array[i];
            array[i] = array[j];
            array[j] = tempValue;
        }
    }
}
