using System.Collections.Concurrent;

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


        public static void QuickSort(int[] array)
        {
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low) return;

                int j = Partition(low, high);
                Sort(low, j - 1);
                Sort(j + 1, high);
            }

            int Partition(int low, int high)
            {
                int i = low;
                int j = high + 1;

                int pivot = array[low];
                while (true)
                {
                    while (array[++i] < pivot)
                    {
                        if (i == high) break;
                    }

                    while (pivot < array[--j])
                    {
                        if (j == low) break;
                    }

                    if (i >= j) break;
                    Swap(array, i, j);
                }
                Swap(array, low, j);
                return j;
            }
        }

        public static void MergeShort(int[] array)
        {
            int[] auxArray = new int[array.Length];
            sort(0, array.Length - 1);

            void sort(int low, int high)
            {
                if (high <= low)
                    return;

                int mid = low + (high - low) / 2;
                sort(low, mid);
                sort(mid + 1, high);
                Merge(low, mid, high);
            }

            void Merge(int low, int mid, int high)
            {
                if (array[mid] <= array[mid + 1])
                    return;

                int i = low;
                int j = mid + 1;
                //Array.Copy(array, low, auxArray, low, high - low + 1);

                for (int h = low; h <= high; h++)
                {
                    auxArray[h]= array[h];
                }

                for (int k = low; k <= high; k++)
                {

                    if (mid < i)
                    {
                        array[k] = auxArray[j++];
                    }
                    else if (high < j)
                    {
                        array[k] = auxArray[i++];
                    }
                    else if (auxArray[j] < auxArray[i])
                    {
                        array[k] = auxArray[j++];
                    }
                    else
                    {
                        array[k] = auxArray[i++];
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
