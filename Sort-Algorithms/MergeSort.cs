namespace SortAlgorithm
{
    public class Program
    {
	public static void Main(string[] args)
        {
	    int[] arrMerge = new int[] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            Console.WriteLine("Merge Sort");
            Console.WriteLine();
            Console.WriteLine("Array Before Sort");
            for (int i = 0; i < arrMerge.Length; i++)
            {
                Console.Write(arrMerge[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            MergeSort(arrMerge);
            Console.WriteLine("Array After Sort");
            for (int i = 0; i < arrMerge.Length; i++)
            {
                Console.Write(arrMerge[i] + " ");
            }          
	}
		
	public static void MergeSort(int[] array)
        {
            MergeSort(array, 0, array.Length - 1);
        }
		
	private static void MergeSort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(input, low, middle);
                MergeSort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }
		
	private static void Merge(int[] input, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp[tmpIndex] = input[left];
                    left += 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right += 1;
                }
                tmpIndex += 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left += 1;
                    tmpIndex += 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[high];
                    right += 1;
                    tmpIndex += 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }
        }

	private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }	
}
