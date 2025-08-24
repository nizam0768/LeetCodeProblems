using System;

class Program
{
    public void BubbleSort(int[] A, int n)
    {
        for (int i = 0; i < n - 1; i++)
        {
            int flag = 0;  // reset before each pass

            for (int j = 0; j < n - 1 - i; j++)
            {
                if (A[j] > A[j + 1])  // ascending order
                {
                    // swap A[j] and A[j+1]
                    int temp = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = temp;
                    flag = 1;
                }
            }

            if (flag == 0) // no swaps → already sorted
                break;
        }
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        int n = array.Length;

        program.BubbleSort(array, n);

        Console.WriteLine("Sorted array:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}
