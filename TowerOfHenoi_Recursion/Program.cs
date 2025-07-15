class Program
{
     void TowerofHenoi(int n, int A, int B, int C)
    {
        if(n>0)
        {
            TowerofHenoi(n - 1, A, C, B);
            Console.WriteLine($"({A},{C})");
            TowerofHenoi(n - 1, B, A, C);
        }
    }
    static void Main(string[] args)
    {
        int n = 3; 
        Program program = new Program();
        program.TowerofHenoi(n,1,2,3); // A, B and C are names of rods
    }
}