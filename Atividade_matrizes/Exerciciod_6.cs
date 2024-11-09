using System;
using Biblioteca_Matriz;

internal class Exerciciod_6
{
    // Função para somar duas matrizes
    public static int[,] somaMatrizes(int[,] mat1, int[,] mat2)
    {
        int linhas1 = mat1.GetLength(0);
        int cols1 = mat1.GetLength(1);
        int linhas2 = mat2.GetLength(0);
        int cols2 = mat2.GetLength(1);

        // Verifica se as matrizes têm a mesma ordem
        if (linhas1 != linhas2 || cols1 != cols2)
        {
            Console.WriteLine("As matrizes não têm a mesma ordem e não podem ser somadas.");
            return null;
        }

        // Cria uma matriz para armazenar o resultado da soma
        int[,] soma = new int[linhas1, cols1];

        for (int i = 0; i < linhas1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                soma[i, j] = mat1[i, j] + mat2[i, j];
            }
        }

        return soma;
    }

    static void Main()
    {
        int linhas, cols, linhas2, cols2;
        Console.WriteLine("Informe a quantidade de linhas e colunas para a primeira matriz:");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de linhas e colunas para a segunda matriz:");
        linhas2 = int.Parse(Console.ReadLine());
        cols2 = int.Parse(Console.ReadLine());

        int[,] x = new int[linhas, cols];
        int[,] y = new int[linhas2, cols2];

        // Gera valores aleatórios para as matrizes
        Matriz.gera(x);
        Matriz.gera(y);

        // Mostra as matrizes geradas
        Console.WriteLine("Matriz X:");
        Matriz.mostra(x);
        Console.WriteLine("\nMatriz Y:");
        Matriz.mostra(y);

        // Calcula e mostra a soma das matrizes, se possível
        int[,] soma = somaMatrizes(x, y);
        if (soma != null)
        {
            Console.WriteLine("\nA soma das matrizes é:");
            Matriz.mostra(soma);
        }

        Console.ReadKey();
    }
}
