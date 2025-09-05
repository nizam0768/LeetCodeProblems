class Program
{
    int hash(int key)
    {
        return key % 10;
    }
    int probe(int[] H, int key)
    {
        int index = hash(key);
        int i = 0;
        while (H[(index+1)%10] !=0)
        {
            i++;
        }
        return (index + i) % 10;
    }
    void Insert(int[] H, int key)
    {
        int index = hash(key);
        if (H[index] !=0)
        {
            index = probe(H, key);
        }
        H[index] = key;
    }
    int Search(int[] H, int key)
    {
        int index = hash(key);
        int i = 0;
        while (H[(index+i)%10] != key)
        {
            i++;
        }
        return (index + i) % 10;
    }
    static void Main(string[] args)
    {
        int[] HT = new int[10];
        Program program = new Program();
        program.Insert(HT, 12);
        program.Insert(HT, 25);
        program.Insert(HT, 35);
        program.Insert(HT, 26);
        Console.WriteLine(program.Search(HT,35));
    }
}