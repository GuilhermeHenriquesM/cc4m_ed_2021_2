using System;

class Program
{
    static void Main(string[] args)
    {
        Notas notas = new Notas(5);

        notas.LerNota();
        notas.LerNota();
        notas.LerNota();
        notas.LerNota();
        notas.LerNota();

        notas.ExibirNotas();

        Console.WriteLine("Hello World!");
    }
}
