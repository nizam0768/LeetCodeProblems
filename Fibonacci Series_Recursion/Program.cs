class Program
{
    int rfib(int n)
    {
        if (n <= 1)
            return n;
        return rfib(n - 1) + rfib(n - 2); // Recursive call to calculate Fibonacci number
    }
    int memoizedFib(int n, int[] memo)
    {
        if (n <= 1)
            return n;
        if (memo[n] != -1)
            return memo[n];
        memo[n] = memoizedFib(n - 1, memo) + memoizedFib(n - 2, memo);
        return memo[n];
    }
    static void Main(string[] args)
    {
        int n = 5; // Number of terms in the Fibonacci series
        // Using memoization to optimize the Fibonacci calculation
        int[] memo = new int[n + 1];
        for (int i = 0; i <= n; i++)
            memo[i] = -1; // Initialize memoization array with -1
        Program program = new Program();
        int rfi = program.rfib(n);
        int memoizedResult = program.memoizedFib(n, memo);
        Console.WriteLine(memoizedResult);
    }
}