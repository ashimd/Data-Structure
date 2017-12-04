namespace SortAlgorithm
{
	public class Program
	{
		public static void Main(string[] args)
        {
			int[] arrInsertion = new int[] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            Console.WriteLine("Insertion Sort");
            Console.WriteLine();
            Console.WriteLine("Array Before Sort");
            for (int i = 0; i < arrInsertion.Length; i++)
            {
                Console.Write(arrInsertion[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            InsertionSort(arrInsertion);
            Console.WriteLine("Array After Sort");
            for (int i = 0; i < arrInsertion.Length; i++)
            {
                Console.Write(arrInsertion[i] + " ");
            }            
		}
		
		public static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int j = i + 1;
                while (j > 0)
                {
                    if (array[j - 1] > array[j])
                        Swap(array, j - 1, j);
                    j--;
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
