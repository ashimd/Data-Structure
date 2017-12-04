namespace SortAlgorithm
{
    public class Program
    {
	public static void Main(string[] args)
        {
	    int[] arrRadix = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("Radix Sort");
            Console.WriteLine();
            Console.WriteLine("Array Before Sort");
            for (int i = 0; i < arrRadix.Length; i++)
            {
                Console.Write(arrRadix[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            RadixSort(arrRadix);
            Console.WriteLine("Array After Sort");
            for (int i = 0; i < arrRadix.Length; i++)
            {
                Console.Write(arrRadix[i] + " ");
            }
	}
		
	public static void RadixSort(int[] arr)
        {
            int i, j;
            int[] tmp = new int[arr.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    bool move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
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
