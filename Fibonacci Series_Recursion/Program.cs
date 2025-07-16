class Program
{
    int rfib(int n)
    {
        if (n <= 1)
            return n;
        return rfib(n - 1) + rfib(n - 2);
    }
    static void Main(string[] args)
    {
        int n = 5; // Number of terms in the Fibonacci series
        Program program = new Program();
        int rfi = program.rfib(n);
        Console.WriteLine(rfi);
    }
}