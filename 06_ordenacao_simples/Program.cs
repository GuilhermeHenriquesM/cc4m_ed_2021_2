using System;

class Program
{
    static void Main(string[] args)
    {
        //Inicializar vetor
        int[] vetor1 = new int[1000];
        Random rand = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = rand.Next(0, 1000);
        }

        //Ordenar
        Ordenacao ordenacao = new Ordenacao();
        ordenacao.Bubblesort(vetor1);

        //Exibir
        foreach (var item in vetor1)
        {
            Console.Write($"{item} - ");
        }
    }
}
