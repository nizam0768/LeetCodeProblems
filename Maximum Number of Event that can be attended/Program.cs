class Program
{
    public static int MaxEvents(int[][] events)
    {
        Array.Sort(events, (a, b) => a[1].CompareTo(b[1]));                
        var lastEndTime = -1;
        var count = 0;
        foreach (var e in events)
        {
            if (e[0] > lastEndTime)
            {
                count++;
                lastEndTime = e[1];
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        int[][] events = new int[][]
        {
            new int[] {1, 2},
            new int[] {3, 4},
            new int[] {0, 6},
            new int[] {5, 7},
            new int[] {8, 9},
            new int[] {1, 2}
        };
        Console.WriteLine(MaxEvents(events)); // Output: 5
    }
}