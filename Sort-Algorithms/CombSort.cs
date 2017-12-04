namespace SortAlgorithm
{
	public class Program
	{
		public static void Main(string[] args)
        {
			int[] arrComb = new int[] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            Console.WriteLine("Comb Sort");
            Console.WriteLine();
            Console.WriteLine("Array Before Sort");
            for (int i = 0; i < arrComb.Length; i++)
            {
                Console.Write(arrComb[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            CombSort(arrComb);
            Console.WriteLine("Array After Sort");
            for (int i = 0; i < arrComb.Length; i++)
            {
                Console.Write(arrComb[i] + " ");
            }
		}
		
		public static void CombSort(int[] array)
        {
            int n = array.Length;
            int gap = n;

            bool swapped = true;

            while (gap != 1 || swapped == true)
            {
                gap = GetNextGap(gap);

                swapped = false;

                for (int i = 0; i < n - gap; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        Swap(array, i, i + gap);
                        swapped = true;
                    }
                }
            }
        }

        private static int GetNextGap(int gap)
        {
            // Shrink gap by shrink factor
            gap = (gap * 10) / 13;

            if (gap < 1)
                return 1;
            return gap;
        }

		private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
	}	
}
