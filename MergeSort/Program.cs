class Program
{
    void MergeSort(int[] Arr, int l, int h)
    {
        int mid;
        if(l<h)
        {
            mid = (l + h) / 2;
            MergeSort(Arr, l, mid);
            MergeSort(Arr, mid+1, h);
            Merge(Arr, l, mid, h);
        }
    }
    void Merge(int[] A, int l, int mid, int h)
    {
        int i = l; int j = mid+1; int k = l;
        int[] B = new int[A.Length];
        while(i <= mid && j <= h)
        {
            if (A[i] < A[j])
            {
                B[k++] = A[i++];
            }
            else
                B[k++] = A[j++];
        }
        for(; i<=mid; i++)
        {
            B[k++] = A[i];
        }
        for(; j<=h; j++)
        {
            B[k++] = A[j];
        }
        //copy back to orignal array
        for(int m = l;  m<=h; m++)
        {
            A[m] = B[m];
        }
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        int[] arr = { 18, 12, 34, 14, 55, 16, 77, 88, 19, 20};
        program.MergeSort(arr, 0, arr.Length - 1);
        Console.WriteLine("After Merge Sort:");
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
    }
}