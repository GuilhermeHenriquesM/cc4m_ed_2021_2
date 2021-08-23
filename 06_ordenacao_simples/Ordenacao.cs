using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ordenacao
{
    public void Bubblesort(int[] vet)
    {
        for (int j = 0; j < vet.Length; j++)
        {
            for (int i = 0; i < vet.Length - 1; i++)
            {
                if (vet[i] > vet[i+1])
                {
                    int aux = vet[i];
                    vet[i] = vet[i + 1];
                    vet[i + 1] = aux;
                }
            }
        }
    }
    public void Insertionsort(int[] vet)
    {

    }
    public void Selectionsort(int[] vet)
    {

    }
}
