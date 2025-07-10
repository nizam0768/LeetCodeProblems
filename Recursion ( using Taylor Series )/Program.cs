class Program
{
    static class TylorSeries
    {
        static double P = 1, F = 1;
        public static double ePowx(int x, int n)
        {
            double s;
            if (n == 0)
                return 1;
            s = ePowx(x, n - 1);
            P *= x;
            F *= n;
            return s + P / F;
        }
    }
    static void Main(string[] args)
    {
         double x = TylorSeries.ePowx(2, 10);
        Console.WriteLine(x);
    }
}