using System;
using System.IO.IsolatedStorage;
using Biblioteca_Matriz;


namespace Atividade_Matriz

{
    internal class Exerciciob_3

    {

        public static int ocorrencias(int[,] mat, int x)
        {
            int linhas = mat.GetLength(0);
            int cols = mat.GetLength(1);
            int contador = 0;

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mat[i, j] == x)
                    {
                        contador++;
                    }
                }
            }

            return contador;
        }

        static void Main()
        {
            int linhas, cols, x;
            Console.WriteLine("quantidade de linhas e colunas:");
            linhas = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            Console.WriteLine("digite uma numero: ");
            x = int.Parse(Console.ReadLine());
            int[,] matrix = new int[linhas, cols];
            Matriz.gera(matrix);
            Console.WriteLine("Matriz gerada");
            Matriz.mostra(matrix);
            Console.WriteLine($"O numero {x} aparece {ocorrencias(matrix, x)} vezes na matriz. ");
            Console.ReadKey();

        }
    }
}