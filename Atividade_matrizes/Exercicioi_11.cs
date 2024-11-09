using System;
using Biblioteca_Matriz;

internal class Exercicioi_11
{

    static void Main()
    {
        static int somadiagonalPrincipal(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int soma = 0;
            for (int i = 0; i < linhas; i++)
            {
                Console.Write($"|{mat[i, i]}|");
                soma += mat[i, i];
            }//fim for
            Console.WriteLine();
            return soma;

        }//fim soma diagonal principal



        static int somadiagonalSecundaria(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int cols = mat.GetLength(1);
            int j = cols - 1;
            int soma = 0;
            for (int i = 0; i < linhas; i++, j--)
            {
                Console.Write($"|{mat[i, j]}|");
                soma += mat[i, j];
            }//fim for 
            Console.WriteLine();
            return soma;

        }//fim diagonal secundaria


        int Coluna, Linha, resultado, resultado2;

        Console.WriteLine("Quantas linhas e quantas colunas vão ser necessárias pra sua matriz: ");

        Linha = int.Parse(Console.ReadLine());
        Coluna = int.Parse(Console.ReadLine());
        if (Linha == Coluna)
        {
            int[,] matrix = new int[Linha, Coluna];
            Matriz.gera(matrix);
            Console.WriteLine("\nMapa do Tesouro (Quantidade de Moedas em Cada Região): ");
            Matriz.mostra(matrix);
            Console.WriteLine("\n");
            Console.WriteLine($"Soma da Diagonal Principal: {somadiagonalPrincipal(matrix)}\n");
            Console.WriteLine($"Soma da Diagonal Secundária: {somadiagonalSecundaria(matrix)}");
            Console.WriteLine("\n");

            if (somadiagonalPrincipal(matrix) < somadiagonalSecundaria(matrix))
            {
                Console.WriteLine("O maior tesouro está na diagonal secundaria, vamos para lá! ");
            }
            else
            {
                Console.WriteLine("O maior tesouro está na diagonal Principal, vamos para lá! ");
            }

        }
        else
        {
            Console.WriteLine("Não é possivel apresentar dados pra esta dimensão!!");
        }
        Console.ReadKey();
    }
}