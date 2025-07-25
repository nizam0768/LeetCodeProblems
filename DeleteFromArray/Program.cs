class Program
{
    public static int[] DeleteFromArray(int[] originalArray, int indexToDelete)
    {
        if (indexToDelete < 0 || indexToDelete >= originalArray.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(indexToDelete), "Index is out of bounds.");
        }
        int[] newArray = new int[originalArray.Length - 1];
        for (int i = 0, j = 0; i < originalArray.Length; i++)
        {
            if (i != indexToDelete)
            {
                newArray[j++] = originalArray[i];
            }
        }
        return newArray;
    }
    static void Main(string[] args)
    {
        int[] originalArray = { 1, 2, 3, 4, 5 };
        int indexToDelete = 2; // Index of the element to delete
        int[] newArray = DeleteFromArray(originalArray, indexToDelete);
        Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
        Console.WriteLine("New Array after deletion: " + string.Join(", ", newArray));
    }
}