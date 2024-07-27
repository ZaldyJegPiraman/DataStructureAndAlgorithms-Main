using System;
using System.Collections.Generic;


// GRADING CODE ===================================================
//int grade = 96;
//Console.WriteLine((grade % 5) > 0 ? (Convert.ToInt32(grade / 5) + 1) * 5 : grade );


// STAIR CASE CODE ================================================
//int n = 6;
//string stairs = string.Empty; 

//for (int i = 0; i < n; i++)
//{
//    string blocks = string.Empty;
//    string pound = string.Empty;

//    for (int j = 0; j < (n - (i + 1)); j++)
//    {
//        blocks = blocks + " ";
//    }

//    for (int j = 0; j < (i + 1); j++)
//    {
//        pound = pound + "#";
//    }

//    Console.WriteLine(blocks + pound);

//}

//Console.ReadLine();



// TIME CONVERSION CODE ===========================================
//string s = "7:00:00PM";
//bool successfulConversion = DateTime.TryParse(s, out DateTime time);
//if(successfulConversion)
//{
//    Console.WriteLine(time.ToString("HH:mm:ss"));
//}
//else
//{
//    Console.WriteLine("HackerRank gave me bad input");
//}

//Console.ReadLine();


// COUNT THE VALLEYS CODE ===========================================

//Console.WriteLine(countingValleys(8,"UDDDUDUU"));
//Console.ReadLine();

//int countingValleys(int steps, string path)
//{
//    int altitude = 0;
//    int valley = 0;
//    for (int i = 0; i < steps; i++)
//    {
//        if (path[i] == 'U')
//        {
//            if(altitude == -1)
//            {
//                valley++;
//            }
//            altitude++;
//        }

//        if (path[i] == 'D')
//        {
//            altitude--;
//        }

//    }

//    return valley;
//}


// COMPARE TRIPLETS ==============================================
//List<int> compareTriplets(List<int> a, List<int> b)
//{
//    List<int> scores = new List<int>() { 0, 0};
//    for (int i = 0; i < a.Count; i++)
//    {
//        if (a[i] > b[i]) scores[0]++;
//        else if (a[i] < b[i]) scores[1]++;
//    }

//    return scores;
//}


// HOURGLASS SUM =================================================

//int hourglassSum(int[][] arr)
//{
//    List<int> sums = new List<int>();

//    for (int y = 1; y < 5; y++)
//    {
//        for (int x = 1; x < 5; x++)
//        {
//            int sum = arr[y-1][x-1] + arr[y-1][x] + arr[y-1][x+1]
//                                    + arr[y][x]   +
//                      arr[y+1][x-1] + arr[y+1][x] + arr[y+1][x];
//        }
//    }

//    return sums.Max();
//}

// LEFT ROTATION =================================================
//int n = 0;
//int d = 0;
//int[] a = null;
//d = d % n;

//for (int i = d; i < a.Length; i++)
//{
//    Console.Write($"{a[i]} ");
//}
//for (int i = 0; i < d; i++)
//{
//    Console.Write($"{a[i]} ");
//}

// HASH TABLE CODE START HERE ====================================

HashTable hashTable = new HashTable(10);
hashTable.Add("123", "Harry Potter");
hashTable.Add("456", "The Hobbit");

Console.WriteLine("Get value with key 123: " + hashTable.Get("123")); // Output: Harry Potter
Console.WriteLine("Get value with key 456: " + hashTable.Get("456")); // Output: The Hobbit
Console.ReadLine();


public class HashTable
{
    private readonly int size;
    private readonly LinkedList<KeyValuePair<string, string>>[] items;

    public HashTable(int size)
    {
        this.size = size;
        items = new LinkedList<KeyValuePair<string, string>>[size];
    }

    private int GetArrayPosition(string key)
    {
        int hashCode = key.GetHashCode();
        int position = hashCode % size;
        return Math.Abs(position);
    }

    public void Add(string key, string value)
    {
        int position = GetArrayPosition(key);
        LinkedList<KeyValuePair<string, string>> linkedList = GetLinkedList(position);
        KeyValuePair<string, string> item = new KeyValuePair<string, string>(key, value);
        linkedList.AddLast(item);
    }

    public string Get(string key)
    {
        int position = GetArrayPosition(key);
        LinkedList<KeyValuePair<string, string>> linkedList = GetLinkedList(position);
        foreach (KeyValuePair<string, string> pair in linkedList)
        {
            if (pair.Key.Equals(key))
            {
                return pair.Value;
            }
        }
        return null;
    }

    private LinkedList<KeyValuePair<string, string>> GetLinkedList(int position)
    {
        LinkedList<KeyValuePair<string, string>> linkedList = items[position];
        if (linkedList == null)
        {
            linkedList = new LinkedList<KeyValuePair<string, string>>();
            items[position] = linkedList;
        }
        return linkedList;
    }
}
