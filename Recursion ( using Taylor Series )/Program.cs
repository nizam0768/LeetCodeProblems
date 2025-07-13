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
/*
 * To find e^x using the recursive function, we need to use static variables. A function can return only one value, and when we need to include multiple values in a recursive function, we use static variables. The Taylor Series is a combination of multiple values like sum, power and factorial term, hence we will use static variables.

For the power of x, we will use p, and for factorials, we will use f as static variables. 
 */