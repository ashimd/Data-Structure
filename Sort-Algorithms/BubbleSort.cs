namespace SortAlgorithm
{
	public class Program
	{
		public static void Main(string[] args)
        {
			int[] arrBubble = new int[] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            Console.WriteLine("Bubble Sort");
            Console.WriteLine();
            Console.WriteLine("Array Before Sort");
            for (int i = 0; i < arrBubble.Length; i++)
            {
                Console.Write(arrBubble[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            BubbleSort(arrBubble, true);
            Console.WriteLine("Array After Sort");
            for (int i = 0; i < arrBubble.Length; i++)
            {
                Console.Write(arrBubble[i] + " ");
            }   
		}
		
		public static void BubbleSort(int[] array, bool recursive)
        {
            if (recursive)
                BubbleSort(array, array.Length);
            else
                BubbleSort(array);
        }

        // Iterative
        private static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                        Swap(array, j, j + 1);
                }
            }
        }

        // recursive
        private static void BubbleSort(int[] array, int n)
        {
            if (n == 1)
                return;

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                    Swap(array, i, i + 1);
            }
            BubbleSort(array, n - 1);
        }

		private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
	}	
}
