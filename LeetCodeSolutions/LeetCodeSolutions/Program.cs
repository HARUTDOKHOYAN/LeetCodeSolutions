using LeetCodeSolutions;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
        {
        HeapSort(new int[] {4,9,7,3,2,8 } );
    }
    public static int[] HeapSort(int[] array)
    {
        buildMaxHeap(array);
        for (int i = array.Length -1; i > 0; i--)
        {
            Swap(0, i, array);
            heapify(array, i-1, 0);
        }

        return array;
    }
    private static void buildMaxHeap(int[] array)
    {
        for (int i = array.Length/2 -1; i >= 0; i--)
        {
            heapify(array, array.Length, i);
        }
    }
    private static void heapify(int[] array, int endArray, int rootIndex)
    {

        while (true)
        {
            int largIndex = rootIndex;
            int left = rootIndex*2 +1;
            int right = rootIndex*2 +2;

            if (left < endArray && array[left] > array[largIndex])
                largIndex = left;
            if (right < endArray && array[right] > array[largIndex])
                largIndex = right;

            if (rootIndex == largIndex) break;

            Swap(largIndex, rootIndex, array);
            rootIndex = largIndex;
        }
    }
    private static void Swap(int i, int j, int[] arr)
    {
        var temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
