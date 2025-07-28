class Program
{
    static void swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    static int LinearSearch(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                swap(ref array[i], ref array[i-1]); // Swap the found element with the target
                return i; // Return the index of the found element
            }
        }
        return -1; // Return -1 if the element is not found
    }
    static void Main(string[] args)
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int target = 30; // Element to search for
        int index = LinearSearch(array, target);
        
        if (index != -1)
        {
            Console.WriteLine($"Element {target} found at index: {index}");
        }
        else
        {
            Console.WriteLine($"Element {target} not found in the array.");
        }
    }
}