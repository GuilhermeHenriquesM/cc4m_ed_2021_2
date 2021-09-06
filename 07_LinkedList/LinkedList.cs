using System;
class LinkedList
{
    public Node head;
    private int _count = 0;

    public LinkedList()
    {
        head = null;
    }
    public void AddFirst(int valor)
    {
        Node node = new Node(valor);
        node.next = head;
        head = node;
        
        _count++;
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
    public bool IsEmpty()
    {
        return head == null;
    }
    public Node Find(int key)
    {
        Node aux = head;
        while (aux != null && aux.data != key)
        {
            aux = aux.next;
        }
        return aux;
    }
    public void Remove(int key)
    {   //Se tiver que remover o primeiro
        if(head != null && head.data == key)
        {
            head = head.next;
            _count--;
            return;
        }
        //Caso geral
        Node aux = head;
        while(aux.next != null && aux.next.data != key)
        {
            aux = aux.next;
        }
        //Garantir que encontrou antes de remover
        if(aux.next != null) 
        { 
            aux.next = aux.next.next;
            _count--;
        }
    }
    public int Count()
    {
        return _count;
    }
    public void Clear()
    {
        if (head == null)
            return;

        Node ant = head;
        Node aux = head.next;

        while (aux != null)
        {
            ant.next = null;
            ant = aux;
            aux = aux.next;
        }

        head = null;
        _count = 0;
    }
    //addLast

    //addOrdered


}

