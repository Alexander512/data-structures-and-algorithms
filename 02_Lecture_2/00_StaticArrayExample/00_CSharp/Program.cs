using System;

namespace Algorithm;

public class StaticArrayExample
{
    public static void Main(string[] args)
    {
        var length = 3;

        var array = new StaticArray(length);

        Console.WriteLine($"a container has been created with length: {array.Count}");
        Console.Write("\n");

        array.SetAt(0, 1);
        array.SetAt(1, 2);
        array.SetAt(2, 3);

        Console.WriteLine("SetAt operations have been performed with the following result:");
        array.IterSequence();

        Console.Write("\n");

        array.DeleteFirst();

        Console.WriteLine("DeleteFirst operation has been performed with the following result:");
        array.IterSequence();

        Console.Write("\n");

        array.InsertFirst(1);

        Console.WriteLine("InsertFirst operation has been performed with the following result:");
        array.IterSequence();

        Console.Write("\n");

        array.DeleteLast();

        Console.WriteLine("DeleteLast operation has been performed with the following result:");
        array.IterSequence();

        Console.Write("\n");

        array.InsertLast(3);

        Console.WriteLine("InsertLast operation has been performed with the following result:");
        array.IterSequence();

        Console.Write("\n");

        array.InsertAt(1, 5);

        Console.WriteLine("InsertAt operation has been performed with the following result:");
        array.IterSequence();

        Console.Write("\n");
        
        array.DeleteAt(1);

        Console.WriteLine("DeleteAt operation has been performed with the following result:");
        array.IterSequence();
    }
}

public class StaticArray
{
    private int _length;

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

    public int Count
    {
        get => this._length;
        set => this._length = value;
    }

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
            Console.WriteLine($"index: {i}\tvalue: {this.GetAt(i)}");
        }
    }

    // The InsertAt method is an O(n) time complexity operation.
    public void InsertAt(int i, int value)
    {
        // Creating a new container is an O(n) time complexity operation.
        var newArray = new int[this.Count + 1];

        // Assigning items from the existing array to the new array is
        // an O(n) time complexity operation.
        for (int j = 0; j < this.Count; j++)
        {
            newArray[j] = this.Data[j];
        }

        // Shifting the values in the new array is an O(n) time complexity
        // operation.
        for (int k = newArray.Length - 2; k >= i; k--)
        {
            newArray[k + 1] = newArray[k];
        }

        // Assigning the new value is an O(1) time complexity operation.
        newArray[i] = value;

        this.Data = newArray;
        this.Count += 1;
    }

    // The DeleteAt method is an O(n) time complexity operation.
    public void DeleteAt(int i)
    {
        // Unshifting the values in the existing array is an O(n) time complexity 
        // operation.
        for (int j = i; j < this.Count - 1; j++)
        {
            this.Data[j] = this.Data[j + 1];
        }
      
        // Creating a new container in an O(n) time complexity operation.
        var newArray = new int[this.Count - 1];

        // Assigning values from the existing array to the new array is an O(n) time 
        // complexity operation.
        for (int k = 0; k < newArray.Length; k++)
        {
            newArray[k] = this.Data[k];
        }

        this.Data = newArray;
        this.Count -= 1;
    }

    // The InsertFirst method is an O(n) time complexity operation.
    public void InsertFirst(int value)
    {
        this.InsertAt(0, value);
    }

    // The DeleteFirst method is an O(n) time complexity operation.
    public void DeleteFirst()
    {
        this.DeleteAt(0);
    }

    // The InsertLast method is an O(n) time complexity operation.
    public void InsertLast(int value)
    {
        this.InsertAt(this.Count, value);
    }

    // The DeleteLast method is an O(n) time complexity operation.
    public void DeleteLast()
    {
        this.DeleteAt(this.Count);
    }

}
