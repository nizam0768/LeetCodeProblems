class Program
{
    public void InsertionSort(int[] A, int n)
    {
        for(int i = 1; i<n; i++)
        {
            int key = A[i];
            int j = i - 1;
            while(j >=0 && A[j] > key)
            {
                A[j + 1] = A[j];
                j--;
            }
            A[j + 1] = key;
        }
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        int[] array = { 12, 11, 13, 5, 6 };
        int n = array.Length;
        program.InsertionSort(array, n);
        Console.WriteLine("Sorted array:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}