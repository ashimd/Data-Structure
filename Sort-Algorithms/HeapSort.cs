namespace SortAlgorithm
{
   public class Program
   {
	public static void Main(string[] args)
        {
	    int[] arrHeap = new int[] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            Console.WriteLine("Heap Sort");
            Console.WriteLine();
            Console.WriteLine("Array Before Sort");
            for (int i = 0; i < arrHeap.Length; i++)
            {
                Console.Write(arrHeap[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            HeapSort(arrHeap);
            Console.WriteLine("Array After Sort");
            for (int i = 0; i < arrHeap.Length; i++)
            {
                Console.Write(arrHeap[i] + " ");
            }           
	}
		
	public static void HeapSort(int[] array)
        {
            // Build Max-Heap
            int heapSize = array.Length;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                MaxHeapify(array, heapSize, p);

            for (int i = array.Length - 1; i > 0; i--)
            {
                Swap(array, i, 0);
                heapSize--;
                MaxHeapify(array, heapSize, 0);
            }
        }
		
	private static void MaxHeapify(int[] input, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && input[left] > input[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && input[right] > input[largest])
                largest = right;

            if (largest != index)
            {
                Swap(input, index, largest);
                MaxHeapify(input, heapSize, largest);
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
