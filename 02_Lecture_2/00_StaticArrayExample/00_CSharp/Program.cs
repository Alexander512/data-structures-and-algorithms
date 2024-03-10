using System;

namespace Algorithm;

public class StaticArrayExample
{
    public static void Main(string[] args)
    {
        var length = 10;

        // New static array build operation O(n) time complexity.
        var array = new StaticArray(length);

        // SetAt operation O(1) time complexity;
        array.SetAt(0, 1);

        // GetAt operation O(1) time complexity;
        var value = array.GetAt(0);

        Console.WriteLine($"result of set and get operations: {value}");
        Console.WriteLine($"length of the array: {array.Length()}");

        array.IterSequence();
    }
}

public class StaticArray
{
    private readonly int _length;

    /*
        The constructor will represent the build step. Based
        on the length(n) provided, an array of length n will
        be built. This is an O(n) time complexity operation.
    */
    public StaticArray(int length)
    {
        _length = length;

        Data = new int[_length];
    }

    public int Count => this._length;

    public int[] Data { get; set; }

    // The Length method is an O(1) time complexity operation.
    public int Length()
    {
        return this.Count;
    }

    /*
        For both the GetAt and SetAt methods the index will
        not be checked for being in range. C# will throw an
        IndexOutOfRangeException if this occurs.
    */

    // The GetAt method is an O(1) time complexity operation.
    public int GetAt(int index)
    {
        return this.Data[index];
    }

    // The SetAt method is an O(1) time complexity operation.
    public void SetAt(int index, int value)
    {
        this.Data[index] = value;
    }

    // The IterSequence method is an O(n) time complexity operation.
    public void IterSequence()
    {
        for (int i = 0; i < this.Count; i++)
        {
            Console.WriteLine($"index: {i}\tvalue: {this.Data[i]}");
        }
    }
}
