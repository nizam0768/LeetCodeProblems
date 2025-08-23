public class Node
{
    public int Data;
    public Node Next;
}
public class LinkedList
{
    private Node head;
    public void InsertAtBeginning(int data)
    {
        Node newNode = new Node { Data = data, Next = head };
        head = newNode;
    }
    public void Add(int data)
    {
        Node newNode = new Node { Data = data, Next = null };
        if (head == null)
        {
            head = newNode;
            return;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }
    public void InsertAtPosition(int data, int position)
    {
        if(position < 1)
        {
            Console.WriteLine("Position should be > 1");
            return;
        }
        if(position == 1)
        {
            InsertAtBeginning(data);
            return;
        }
        Node newNode = new Node { Data = data, Next = null };
        Node current = head;
        for (int i = 1; i < position-1 && current != null; i++)
        {
            current = current.Next;
        }
        if(current == null)
        {
            Console.WriteLine("Position is greater than the length of the list");
            return;
        }
        else
        {
            newNode.Next = current.Next;
            current.Next = newNode;
        }
    }
    public void PrintList()
    {
        Node current = head;

        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }

    }
}
class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.InsertAtBeginning(5);
        list.InsertAtPosition(15, 3);
        list.PrintList();
    }
}