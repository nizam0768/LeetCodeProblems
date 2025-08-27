class Program
{
    public void QuickSort(int[] A, int l, int h)
    {
        if(l<h)
        {
            int j = Partition(A, l, h);
            QuickSort(A, l, j);
            QuickSort(A, j + 1, h);
        }
    }
    private static int Partition(int[] A, int l, int h)
    {
        int pivot = A[l];
        int i = l, j = h;
        do
        {
            do { i++; } while (A[i] <= pivot);
            do { j--; } while (A[j] > pivot);
            if (i < j) // swap A[i] and A[j]
            {
                int temp = A[i];
                A[i] = A[j];
                A[j] = temp;
            }
        } while (i < j);
        // swap A[l] and A[j]
        int temp1 = A[l];
        A[l] = A[j];    
        A[j] = temp1;
        return j;
    }
    static void Main(string[] args)
    {
        int[] array = { 10, 7, 8, 9, 1, 5, int.MaxValue };
        int n = array.Length;
        Program program = new Program();
        program.QuickSort(array, 0, n-1); 
        Console.WriteLine("Sorted array:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}