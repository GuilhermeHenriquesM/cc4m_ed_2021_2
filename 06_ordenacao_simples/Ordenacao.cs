using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ordenacao
{
    public void Bubblesort(int[] vet)
    {
        bool trocou = false;
        for (int j = 0; j < vet.Length; j++)
        {
            trocou = false;
            for (int i = 0; i < vet.Length - 1 - j; i++)
            {
                if (vet[i] > vet[i+1])
                {
                    int aux = vet[i];
                    vet[i] = vet[i + 1];
                    vet[i + 1] = aux;
                    trocou = true;
                }
            }
            if (!trocou)
                return;
        }
    }
    public void Insertionsort(int[] vet)
    {

    }
    public void Selectionsort(int[] vet)
    {
        for (int j = 0; j < vet.Length; j++)
        {
            int menorInndice = j;
            for (int i = j+1; i < vet.Length; i++)
            {
                if(vet[i] < vet[menorInndice])
                {
                    menorInndice = i;
                }
            }
            int aux = vet[j];
            vet[j] = vet[menorInndice];
            vet[menorInndice] = aux;
        }
    }
}
