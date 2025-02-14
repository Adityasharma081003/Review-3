using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}
class LinkedList
{
    public Node Head;
    public void Append(int data)
    {
        if (Head == null)
        {
            Head = new Node(data);
            return;
        }
        Node temp = Head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = new Node(data);
    }
    public void Reverse()
    {
        Node prev = null, current = Head, next = null;
        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;  
            current = next;  
        }

        Head = prev;
    }
    public void PrintList()
    {
        Node temp = Head;
        while (temp != null)
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }
}
class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();
        list.Append(1);
        list.Append(2);
        list.Append(3);
        list.Append(4);
        list.Append(5);

        Console.WriteLine("Original List:");
        list.PrintList();

        list.Reverse();

        Console.WriteLine("Reversed List:");
        list.PrintList();
    }
}
