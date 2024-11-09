using System;
using Biblioteca_Matriz;

class Exerciciof_8
{
    static void Main()
    {
        int linhas = 300;
        int cols = 1000;

        // Lê o número de registros de raios
        Console.Write("Digite o número de registros de raios: \n");
        int N = int.Parse(Console.ReadLine());

        // Grade para armazenar as ocorrências (1 para posição já ocupada, 0 para posição não ocupada)
        int[,] grade = new int[linhas, cols];
        bool repetido = false;

        for (int i = 0; i < N; i++)
        {
            // Lê as coordenadas X e Y do raio
            Console.WriteLine($"Coordenada do {i + 1}° Raio : ");
            Console.Write("Digite a coordenada X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Digite a coordenada Y: ");
            int Y = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            // Verifica se a posição já foi registrada
            if (X < 0 || X >= linhas || Y < 0 || Y >= cols)
            {
                Console.WriteLine("Coordenada fora dos limites da grade. Tente novamente.");
                i--; // Decrementa o índice para repetir a iteração
            }
            else if (grade[X, Y] > 0)
            {
                repetido = true;
            }
            else
            {
                grade[X, Y] = 1; // Marca a posição como ocupada
            }
        }

        int repetição = (repetido ? 1 : 0);
        // Imprime 1 se houve repetição ou 0 caso contrário
        Console.WriteLine($"\n          {(repetido ? 1 : 0)}\n");

        if (repetição == 0)
        {
            Console.WriteLine($"\n Não houve raios que cairam  no mesmo lugar.");
        }
        else
        {
            Console.WriteLine($"\n Houve raios que caíram no mesmo lugar.");
        }
    }
}
