using System;

namespace Algorithm;

public class StaticArrayExample
{
    public static void Main(string[] args)
    {
        var length = 10;

        // a new static array of length n 
        // O(n) time complexity and O(n) space complexity

        var array = new int[length];

        // get value at index i
        // O(1) time complexity and O(1) space complexity

        var value = array[0];

        // set value at index i
        // O(1) time complexity and O(1) space complexity

        array[0] = 1;

        var printer = new Print();
        printer.PrintArray<int>(array);
    }
}

public class Print
{
    public void PrintArray<T>(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"index: {i}\tvalue: {array[i]}");
        }
    }
}
