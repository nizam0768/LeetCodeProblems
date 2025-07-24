class Program
{
    public int[] SimpleInsertion(int[] OrignalArr, int atIndex, int item)
    {
        //create a new array 
        int[] newArray = new int[OrignalArr.Length + 1];
        for (int i = 0; i < atIndex; i++)
        {
            newArray[i] = OrignalArr[i];
        }
        newArray[atIndex] = item; //Insert item
        for (int j = atIndex; j < OrignalArr.Length; j++)
        { //shift item
            newArray[j + 1] = OrignalArr[j];
        }
        return newArray;
    }
    public int[] InsertionByBackwardIteration(int[] OrignalArr, int atIndex, int item)
    {
        int[] newArray = new int[OrignalArr.Length + 1];
        for(int i = newArray.Length - 1; i >= 0; i--)
        {
            if (i > atIndex)
            {
                newArray[i] = OrignalArr[i - 1];
            }
            else if (i == atIndex)
            {
                newArray[i] = item;
            }
            else
            {
                newArray[i] = OrignalArr[i];
            }
        }
        return newArray;
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        //Insert at index 3, value 5
        int insertAtIndex = 3;
        int insertItem = 5;
        int[] Orignalarr = new int[8];
        Random rnd = new Random();
        //fill array with random value
        for (int i = 0; i < Orignalarr.Length; i++)
        {
            Orignalarr[i] = rnd.Next(1, 100);
        }
        int[] newArr = program.SimpleInsertion(Orignalarr, insertAtIndex, insertItem);
        int[] newArrBackwardIteraton = program.InsertionByBackwardIteration(Orignalarr, insertAtIndex, insertItem);
        // print item 
        Console.WriteLine("------------Orignal Array----------");
        foreach (int i in Orignalarr)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("-------------New Array--------------");
        foreach (int i in newArrBackwardIteraton) {
            Console.WriteLine(i);
        }
    }
}