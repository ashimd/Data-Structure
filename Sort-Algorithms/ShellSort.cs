namespace SortAlgorithm
{
	public class Program
	{
		public static void Main(string[] args)
        {
			int[] arrShell = new int[] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            Console.WriteLine("Shell Sort");
            Console.WriteLine();
            Console.WriteLine("Array Before Sort");
            for (int i = 0; i < arrShell.Length; i++)
            {
                Console.Write(arrShell[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            SortAlgorithm.ShellSort(arrShell);
            Console.WriteLine("Array After Sort");
            for (int i = 0; i < arrShell.Length; i++)
            {
                Console.Write(arrShell[i] + " ");
            } 
		}
		
		public static void ShellSort(int[] array)
        {
            int n = array.Length;

            // Start with one big gap, then reduce the gap
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Do a gapped insertion sort for this gap size.
                // The first gap elements a[0..gap-1] are already in gapped order
                // Keep adding one more element until the entire array is gap sorted
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = temp;
                }
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
