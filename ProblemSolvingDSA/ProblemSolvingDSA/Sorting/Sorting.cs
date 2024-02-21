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

        public static void SelectionSort(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int maxElement = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (array[maxElement] < array[j])
                    {
                        maxElement = j;
                    }
                }
                Swap(array, i, maxElement);
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
