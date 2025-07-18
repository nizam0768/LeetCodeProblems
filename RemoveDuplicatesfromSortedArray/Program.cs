class Program
{
    int[] RemoveDuplicateElement(int[] arr)
    {
        int n = arr.Length;
        int newLength = 0;
        for (int i = 0; i < n; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < newLength; j++)
            {
                if (arr[i] == arr[j])
                {
                    isDuplicate = true; // Mark as duplicate if found
                    break;
                }
            }
            if (!isDuplicate) // If the element is not a duplicate
            {
                arr[newLength] = arr[i]; // Place unique element at the new length index
                newLength++; // Increment the new length for unique elements
            }
        }
        Array.Resize(ref arr, newLength); // Optional: shrink array to new size
        return arr;
    }
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 2, 3, 4, 4, 5 }; // Example array with duplicates
        Program program = new Program();
        int[] arrSize = program.RemoveDuplicateElement(arr); // Call the method to remove duplicates
        Console.WriteLine($"Array after removing duplicates: {arrSize.Length}");

    }
}
