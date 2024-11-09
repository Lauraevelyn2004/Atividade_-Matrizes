using System;
using System.IO.IsolatedStorage;
using Biblioteca_Matriz;


namespace Atividade_Matriz

{
    internal class Exercicioa_1_e_2
    {
        static int maiorValorMatriz(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int cols = mat.GetLength(1);
            int maior = mat[0, 0];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
            }
            return maior;
        }
        static int menorValorMatriz(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int cols = mat.GetLength(1);
            int menor = mat[0, 0];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mat[i, j] < menor)
                    {
                        menor = mat[i, j];
                    }
                }
            }
            return menor;
        }
        static void Main()
        {
            int linhas, cols;
            Console.WriteLine("quantidade de linhas e colunas:");
            linhas = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[linhas, cols];
            Matriz.mostra(matrix);
            Matriz.gera(matrix);
            Console.WriteLine("Matriz gerada");
            Matriz.mostra(matrix);
            Console.WriteLine($"o maior valor: {maiorValorMatriz(matrix)} ");
            Console.WriteLine($"o menor valor: {menorValorMatriz(matrix)}");
            Console.ReadKey();

        }
    }
}