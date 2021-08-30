using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello LinkedList");
        LinkedList list = new LinkedList();
        list.AddFirst(4);
        list.AddFirst(15);
        list.AddFirst(1);
        list.Print();
    }
}

