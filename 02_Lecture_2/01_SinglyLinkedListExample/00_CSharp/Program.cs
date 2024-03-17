using System;

namespace Algorithm;

public class SinglyLinkedListExample
{
    public static void Main(string[] args)
    {
        var singlyLinkedList = new SinglyLinkedList();

        Console.WriteLine($"a container has been created of size: {singlyLinkedList.Size}");
        Console.Write("\n");

        singlyLinkedList.InsertAt(1, 1);
        singlyLinkedList.InsertAt(2, 2);

        Console.WriteLine("two nodes have been added with the following result:");
        singlyLinkedList.IterSequence();

        Console.Write("\n");

        singlyLinkedList.DeleteFirst();

        Console.WriteLine("DeleteFirst operation has been performed with the following result:");
        singlyLinkedList.IterSequence();

        Console.Write("\n");

        singlyLinkedList.InsertFirst(0);

        Console.WriteLine("InsertFirst operation has been performed with the following result:");
        singlyLinkedList.IterSequence();

        Console.Write("\n");

        singlyLinkedList.InsertLast(3);

        Console.WriteLine("InsertLast operation has been performed with the following result:");
        singlyLinkedList.IterSequence();

        Console.Write("\n");

        singlyLinkedList.DeleteLast();

        Console.WriteLine("DeleteLast operation has been performed with the following result:");
        singlyLinkedList.IterSequence();

        Console.Write("\n");

        singlyLinkedList.InsertAt(1, 5);

        Console.WriteLine("InsertAt operation has been performed with the following result:");
        singlyLinkedList.IterSequence();

        Console.Write("\n");

        singlyLinkedList.DeleteAt(1);

        Console.WriteLine("DeleteAt operation has been performed with the following result:");
        singlyLinkedList.IterSequence();
    }
}

public class Node
{
    private int _item;
    private Node? _next;

    public Node(int item, Node? next)
    {
        _item = item;
        _next = next;
    }

    public int Item
    {
        get => _item;
        set => _item = value;
    }

    public Node? Next
    {
        get => _next;
        set => _next = value;
    }
}

public class SinglyLinkedList
{
    private Node _head;
    private int _size;

    // The constructor will represent the build step.
    public SinglyLinkedList()
    {
        _head = new Node(default(int), null);
        _size = 1;
    }

    public Node Head
    {
        get => _head;
        set => _head = value;
    }

    public int Size
    {
        get => _size;
        set => _size = value;
    }

    // The GetAt operation is an O(n) time complexity operation.
    public int? GetAt(int index)
    {
        if (index < 0 || index >= this.Size)
        {
            throw new IndexOutOfRangeException("index out of range");
        }

        int i = 0;
        var currentNode = this.Head;

        while (i < this.Size)
        {
            if (i == index)
            {
                return currentNode.Item;
            }

            if (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            i += 1;
        }

        return null;
    }

    // The SetAt operation is an O(n) time complexity operation.
    public void SetAt(int index, int value)
    {
        if (index < 0 || index >= this.Size)
        {
            throw new IndexOutOfRangeException("index out of range");
        }

        int i = 0;
        var currentNode = this.Head;

        while (i < this.Size)
        {
            if (i == index)
            {
                currentNode.Item = value;
                break;
            }

            if (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            i += 1;
        }
    }

    // The IterSequence operation is an O(n) time complexity operation.
    public void IterSequence()
    {
        int i = 0;
        var currentNode = this.Head;

        while (i < this.Size)
        {
            Console.WriteLine($"index: {i}\tvalue: {currentNode?.Item}");

            currentNode = currentNode?.Next;
            i += 1;
        }
    }

    // The InsertAt operation is an O(n) time complexity operation.
    public void InsertAt(int index, int value)
    {
        if (index < 0 || index > this.Size)
        {
            throw new IndexOutOfRangeException("index out of range");
        }

        if (index == 0)
        {
            var temporary = this.Head;
            this.Head = new Node(value, temporary);
            this.Size += 1;
        }
        else if (index == this.Size)
        {
            int i = 0;
            var currentNode = this.Head;

            while (i < this.Size - 1)
            {
                currentNode = currentNode?.Next;
                i += 1;
            }

            var temporary = currentNode?.Next;
            currentNode.Next = new Node(value, temporary);
            this.Size += 1;
        }
        else
        {
            int i = 0;
            var currentNode = this.Head;

            while (i < index - 1)
            {
                currentNode = currentNode?.Next;
                i += 1;
            }

            var temporary = currentNode?.Next;
            currentNode.Next = new Node(value, temporary);
            this.Size += 1;
        }
    }

    // The DeleteAt operation is an O(n) time complexity operation.
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= this.Size)
        {
            throw new IndexOutOfRangeException("index out of range");
        }

        if (index == 0)
        {
            this.Head = this.Head?.Next;
            this.Size -= 1;
        }
        else if (index == this.Size - 1)
        {
            int i = 0;
            var currentNode = this.Head;

            while (i < index - 1)
            {
                currentNode = currentNode?.Next;
                i += 1;
            }

            currentNode.Next = null;
            this.Size -= 1;
        }
        else
        {
            int i = 0;
            var currentNode = this.Head;

            while (i < index - 1)
            {
                currentNode = currentNode?.Next;
                i += 1;
            }

            var temporary = currentNode?.Next?.Next;
            currentNode.Next = temporary;
            this.Size -= 1;
        }
    }

    // The InsertFirst operation is an O(1) time complexity operation.
    public void InsertFirst(int value)
    {
        this.InsertAt(0, value);
    }

    // The DeleteFirst operation is an O(1) time complexity operation.
    public void DeleteFirst()
    {
        this.DeleteAt(0);
    }

    // The InsertLast operation is an O(n) time complexity operation.
    public void InsertLast(int value)
    {
        this.InsertAt(this.Size, value);
    }

    // The DeleteLast Operation is an O(n) time complexity operation.
    public void DeleteLast()
    {
        this.DeleteAt(this.Size - 1);
    }
}
