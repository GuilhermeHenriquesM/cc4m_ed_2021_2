using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello LinkedList");
        LinkedList list = new LinkedList();
        list.AddOrdered(15);
        list.AddOrdered(1);
        list.AddOrdered(5);
        list.AddOrdered(10);
        list.AddOrdered(7);
        list.AddOrdered(152);
        list.AddLast(3);
        list.Print();

        Console.WriteLine(list.Count());
    }
}

