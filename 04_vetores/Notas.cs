using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Notas
{
    private float[] aluno_notas;
    private float media;
    private int indice = 0;
    public Notas(int numeroNotas)
    {
        aluno_notas = new float[numeroNotas];
    }
    public void LerNota()
    {
        if(indice >= aluno_notas.Length){
            Console.WriteLine("ERRO: Máximo de notas atingindo.");
            return;
        }
        float nota = float.Parse(Console.ReadLine());
        aluno_notas[indice] = nota;
        indice++;
    }
    public void ExibirNotas()
    {
        media = CalculaMedia();
        for (int i = 0; i < indice; i++)
        {
            if (aluno_notas[i] > media)
                Console.WriteLine($"{aluno_notas[i]} - ACIMA");
            else if(aluno_notas[i] < media)
                Console.WriteLine($"{aluno_notas[i]} - ABAIXO");
            else
                Console.WriteLine($"{aluno_notas[i]} - NA MÉDIA");
        }
    }
    private float CalculaMedia()
    {
        float total = 0.0f;
        for (int i = 0; i < indice; i++)
        {
            total += aluno_notas[i];
        }
        return total / indice;
    }
}
