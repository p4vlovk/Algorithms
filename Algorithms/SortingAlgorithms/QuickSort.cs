namespace SortingAlgorithms
{
    public class QuickSort
    {
        public static void Sort(int[] arr, int left, int right)
        {
            int pivotIndex = Partition(arr, left, right);

            if (left < pivotIndex - 1)
            {
                Sort(arr, left, pivotIndex - 1);
            }

            if (pivotIndex < right)
            {
                Sort(arr, pivotIndex, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivotIndex = (left + right) / 2;
            int pivot = arr[pivotIndex];

            while (left <= right)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    left++;
                    right--;
                }

            }

            return left;
        }
    }
}
