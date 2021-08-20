using System;
using System.Collections;

class Curso
{
    public Curso(string nome)
    {
        Nome = nome;
        Notas = new ArrayList();
    }

    public string Nome { get; set; }
    public ArrayList Notas { get; set; }

    public decimal MediaNotas()
    {
        decimal total = 0;
        for (int i = 0; i < Notas.Count; i++)
        {
            total += (decimal) Notas[i];
        }
        return total / Notas.Count;
    }
    public decimal MaiorNota()
    {
        decimal maior = -1;
        for (int i = 0; i < Notas.Count; i++)
        {
            if((decimal)Notas[i] > maior)
            {
                maior = (decimal)Notas[i];
            }
        }
        return maior;
    }
    public decimal MenorNota()
    {
        decimal menor = 11;
        for (int i = 0; i < Notas.Count; i++)
        {
            if ((decimal)Notas[i] < menor)
            {
                menor = (decimal)Notas[i];
            }
        }
        return menor;
    }

}

