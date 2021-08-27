using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int tamanho = 100000;
        //Inicializar vetor
        int[] vetor1 = new int[tamanho];
        Random rand = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = rand.Next(0, tamanho);
        }
        int[] vetor2 = new int[tamanho];
        vetor1.CopyTo(vetor2, 0);
        int[] vetor3 = new int[tamanho];
        vetor1.CopyTo(vetor3, 0);
        int[] vetor4 = new int[tamanho];
        vetor1.CopyTo(vetor4, 0);

        Stopwatch sw = new Stopwatch();
        Ordenacao ordenacao = new Ordenacao();
        
        sw.Start();
        ordenacao.Bubblesort(vetor1);
        sw.Stop();
        Console.WriteLine($"Bubble: {sw.Elapsed.ToString()}");
        sw.Start();
        ordenacao.Insertionsort(vetor2);
        sw.Stop();
        Console.WriteLine($"Insertion: {sw.Elapsed.ToString()}");
        sw.Start();
        ordenacao.Selectionsort(vetor3);
        sw.Stop();
        Console.WriteLine($"Selection: {sw.Elapsed.ToString()}");
        ////Exibir
        //foreach (var item in vetor1)
        //{
        //    Console.Write($"{item} - ");
        //}
    }
}
