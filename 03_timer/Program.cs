using System;
using System.Diagnostics;

namespace _03_timer
{
    class Program
    {
        static void Main(string[] args){
            int[] nums = new int[1000000];
            
            Stopwatch sw = new Stopwatch();
            sw.Start();
            BuildArray(nums);
            sw.Stop();
            Console.WriteLine($"Tempo para construir = {sw.Elapsed}");

            sw.Start();
            PrintArray(nums);
            sw.Stop();
            Console.WriteLine($"Tempo para imprimir = {sw.Elapsed}");
        }

        static void BuildArray(int[] arr){
            Random r = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next();
            }
        }
        static void PrintArray(int[] arr){
            foreach (var item in arr)
            {
                Console.WriteLine($"Valor = {item}");
            }
        }

    }
}
