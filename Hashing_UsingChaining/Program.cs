using System;
using System.Collections.Generic;

public class ChainingHashTable
{
    private LinkedList<KeyValuePair<string, string>>[] table;
    private int size;

    public ChainingHashTable(int size)
    {
        this.size = size;
        table = new LinkedList<KeyValuePair<string, string>>[size];
    }

    private int GetIndex(string key)
    {
        int hashCode = Math.Abs(key.GetHashCode());
        return hashCode % size;
    }

    public void Add(string key, string value)
    {
        int index = GetIndex(key);
        if (table[index] == null)
            table[index] = new LinkedList<KeyValuePair<string, string>>();
        // Replace value if key exists
        foreach (var pair in table[index])
        {
            if (pair.Key == key)
            {
                table[index].Remove(pair);
                break;
            }
        }
        table[index].AddLast(new KeyValuePair<string, string>(key, value));
    }

    public string Get(string key)
    {
        int index = GetIndex(key);
        if (table[index] != null)
        {
            foreach (var pair in table[index])
            {
                if (pair.Key == key)
                    return pair.Value;
            }
        }
        return null;
    }

    public bool Remove(string key)
    {
        int index = GetIndex(key);
        if (table[index] != null)
        {
            var node = table[index].First;
            while (node != null)
            {
                if (node.Value.Key == key)
                {
                    table[index].Remove(node);
                    return true;
                }
                node = node.Next;
            }
        }
        return false;
    }

    public void Print()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Bucket {i}: ");
            if (table[i] != null)
            {
                foreach (var pair in table[i])
                {
                    Console.Write($"[{pair.Key}, {pair.Value}] -> ");
                }
            }
            Console.WriteLine("null");
        }
    }
}

class Program
{
    static void Main()
    {
        // Create a new chaining hash table
        var hashTable = new ChainingHashTable(5);

        // Add key-value pairs
        hashTable.Add("apple", "A fruit");
        hashTable.Add("banana", "A fruit");
        hashTable.Add("carrot", "A vegetable");
        hashTable.Add("date", "A dry fruit");
        hashTable.Add("artichoke", "A vegetable");

        // Get value
        Console.WriteLine("Value for 'carrot': " + hashTable.Get("carrot"));

        // Remove an element
        bool removed = hashTable.Remove("banana");
        Console.WriteLine("Removal of 'banana': " + (removed ? "Success" : "Not found"));

        // Print the hash table
        Console.WriteLine("\nHash Table Contents:");
        hashTable.Print();
    }
}
