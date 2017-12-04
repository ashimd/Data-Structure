namespace SortAlgorithm
{
    public class Program
    {
	public static void Main(string[] args)
        {
	    int[] arrBucket = new int[] { -1, 25, -58964, 8547, -119, 0, 78596 };
            Console.WriteLine("Bucket Sort");
            Console.WriteLine();
            Console.WriteLine("Array Before Sort");
            for (int i = 0; i < arrBucket.Length; i++)
            {
                Console.Write(arrBucket[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            BucketSort(arrBucket);
            Console.WriteLine("Array After Sort");
            for (int i = 0; i < arrBucket.Length; i++)
            {
                Console.Write(arrBucket[i] + " ");
            }
	}
		
	public static void BucketSort(int[] array)
        {
            int minValue = array[0];
            int maxValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                    maxValue = array[i];

                if (array[i] < minValue)
                    minValue = array[i];
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < array.Length; i++)
            {
                bucket[array[i] - minValue].Add(array[i]);
            }

            int k = 0;

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        array[k] = bucket[i][j];
                        k++;
                    }
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
