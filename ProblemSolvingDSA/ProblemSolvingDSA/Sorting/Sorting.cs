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

        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int currentSort = array[i];
                int j = 0;
                for (j = i; j > 0 && array[j - 1] > currentSort; j--)
                {
                    array[j] = array[j - 1];
                }
                array[j] = currentSort;
            }
        }

        public static void ShellSort(int[] array)
        {
            int gap = 1;
            while (gap < array.Length / 3)
                gap = 3 * gap + 1;

            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        Swap(array, j, j - gap);
                    }
                }
                gap /= 3;
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
