class Program
{
    int factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * factorial(n - 1);
    }
    int NCR(int n, int r)
    {
        int x1, x2, x3;
        x1 = factorial(n);
        x2 = factorial(r);
        x3 = factorial(n - r);
        return x1 / (x2 * x3);
    }
    static void Main(string[] args)
    {
        int n, r;
        n = 5;
        r = 3;
        Program P = new Program();
        int NC = P.NCR(n, r);
        Console.WriteLine(NC);
    }
}