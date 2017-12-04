namespace SortAlgorithm
{
	public class Program
	{
		public static void Main(string[] args)
        {
			int[] arrSelection = new int[] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            Console.WriteLine("Selection Sort");
            Console.WriteLine();
            Console.WriteLine("Array Before Sort");
            for (int i = 0; i < arrSelection.Length; i++)
            {
                Console.Write(arrSelection[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            SelectionSort(arrSelection);
            Console.WriteLine("Array After Sort");
            for (int i = 0; i < arrSelection.Length; i++)
            {
                Console.Write(arrSelection[i] + " ");
            }
		}
		
		public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(array, i, minIndex);
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
