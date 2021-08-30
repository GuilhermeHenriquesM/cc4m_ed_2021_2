using System;

class LinkedList
{
    public Node head;
    public LinkedList()
    {
        head = null;
    }

    public void AddFirst(int valor)
    {
        Node node = new Node(valor);
        node.next = head;
        head = node;
    }

    public void Print()
    {
        Node aux = head;
        while (aux != null)
        {
            Console.Write($"[{aux.data}]->");
            aux = aux.next;
        }
        Console.WriteLine("[null]");
    }

    //addLast

    //addOrdered

    //find

    //remove

    //count

}

