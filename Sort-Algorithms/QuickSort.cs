namespace SortAlgorithm
{
    public class Program
    {
	public static void Main(string[] args)
        {
	    int[] arrQuick = new int[] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            Console.WriteLine("Quick Sort");
            Console.WriteLine();
            Console.WriteLine("Array Before Sort");
            for (int i = 0; i < arrQuick.Length; i++)
            {
                Console.Write(arrQuick[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            QuickSort(arrQuick);
            Console.WriteLine("Array After Sort");
            for (int i = 0; i < arrQuick.Length; i++)
            {
                Console.Write(arrQuick[i] + " ");
            }        
	}
		
	public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
                return;

            int pivot = array[start];
            int i = start, j = end;

            while (i < j)
            {
                while (i < j && array[j] > pivot)
                    j--;

                array[i] = array[j];

                while (i < j && array[i] < pivot)
                    i++;

                array[j] = array[i];
            }

            array[i] = pivot;
            QuickSort(array, start, i - 1);
            QuickSort(array, i + 1, end);
        }

	private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }	
}
