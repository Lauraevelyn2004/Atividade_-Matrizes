using System;
using Biblioteca_Matriz; 

class Exercicioh_10
{
    static void Main()
    {

        Console.WriteLine("Informe o número de regiões e o número de cidades em cada região:");
        int R = int.Parse(Console.ReadLine()); 
        int C = int.Parse(Console.ReadLine());  
        int[,] matriz = new int[R, C];

        Matriz.gera(matriz);  
        Console.WriteLine("\nMatriz de tropas (quantidade de tropas em cada cidade):\n");
        Matriz.mostra(matriz);  

        Console.WriteLine("\nSoma total de tropas por região:");
        for (int i = 0; i < R; i++)
        {
            int soma = 0;
            for (int j = 0; j < C; j++)
            {
                soma += matriz[i, j];  
            }
            Console.WriteLine($"Região {i + 1}: {soma} tropas");
        }
    }
}
