using System;
using Biblioteca_Matriz;



internal class Exercicioe_7
{
    //_______________________________________________________________________
    // Foi adicionada á Biblioteca_Matriz as funções:                        |
    // Ler uma matriz de números reais                                       |
    // Gerar uma matriz com valores reais aleatórios                         |
    // Exibir uma matriz de números reais formatados com duas casas decimais |
    //_______________________________________________________________________|


    // Função para somar duas matrizes e retornar o resultado em uma nova matriz
    public static double[,] SomaMatrizes(double[,] mat1, double[,] mat2)
    {
        int linhas = mat1.GetLength(0);
        int cols = mat1.GetLength(1);
        double[,] resultado = new double[linhas, cols];

        for (int i = 0; i < linhas; i++)
            for (int j = 0; j < cols; j++)
                resultado[i, j] = mat1[i, j] + mat2[i, j];

        return resultado;
    }

    // Função para subtrair a primeira matriz da segunda e retornar o resultado em uma nova matriz
    public static double[,] SubtraiMatrizes(double[,] mat1, double[,] mat2)
    {
        int linhas = mat1.GetLength(0);
        int cols = mat1.GetLength(1);
        double[,] resultado = new double[linhas, cols];

        for (int i = 0; i < linhas; i++)
            for (int j = 0; j < cols; j++)
                resultado[i, j] = mat2[i, j] - mat1[i, j];

        return resultado;
    }

    // Função para adicionar uma constante a todos os elementos de uma matriz
    public static void AdicionaConstante(double[,] mat, double constante)
    {
        int linhas = mat.GetLength(0);
        int cols = mat.GetLength(1);
        for (int i = 0; i < linhas; i++)
            for (int j = 0; j < cols; j++)
                mat[i, j] += constante;
    }

    static void Main()
    {
        Console.WriteLine("Informe a quantidade de linhas e colunas para as matrizes:");
        int linhas = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        double[,] matriz1 = new double[linhas, cols];
        double[,] matriz2 = new double[linhas, cols];


        // Gera valores aleatórios para as matrizes usando a biblioteca
        Matriz.gera(matriz1);
        Matriz.gera(matriz2);


        Console.WriteLine("Matriz 1");
        Console.WriteLine("----------------------------------------");
        Matriz.mostra(matriz1);
        Console.WriteLine("----------------------------------------\n");
        Console.WriteLine("Matriz 2");
        Console.WriteLine("----------------------------------------");
        Matriz.mostra(matriz2);
        Console.WriteLine("----------------------------------------\n");

        while (true)
        {
            Console.WriteLine("\nMenu de opções:");
            Console.WriteLine("a) Somar as duas matrizes");
            Console.WriteLine("b) Subtrair a primeira matriz da segunda");
            Console.WriteLine("c) Adicionar uma constante às duas matrizes");
            Console.WriteLine("d) Imprimir as matrizes");
            Console.WriteLine("e) Sair");
            Console.Write("Escolha uma opção: ");
            char opcao = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (opcao)
            {
                case 'a':
                    double[,] soma = SomaMatrizes(matriz1, matriz2);
                    Console.WriteLine("\nResultado da soma das matrizes:");
                    Console.WriteLine("----------------------------------------");
                    Matriz.mostra(soma);
                    Console.WriteLine("----------------------------------------");
                    break;

                case 'b':
                    double[,] subtracao = SubtraiMatrizes(matriz1, matriz2);
                    Console.WriteLine("\nResultado da subtração da primeira matriz da segunda:");
                    Console.WriteLine("----------------------------------------");
                    Matriz.mostra(subtracao);
                    Console.WriteLine("----------------------------------------");
                    break;

                case 'c':
                    Console.Write("\nInforme a constante a ser adicionada: ");
                    double constante = double.Parse(Console.ReadLine());
                    AdicionaConstante(matriz1, constante); // Adiciona à matriz1
                    AdicionaConstante(matriz2, constante); // Adiciona à matriz2
                    Console.WriteLine("\nConstante adicionada diretamente às matrizes originais.");
                    break;


                case 'd':
                    Console.WriteLine("\nMatriz 1:");
                    Console.WriteLine("----------------------------------------");
                    Matriz.mostra(matriz1);
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("\nMatriz 2:");
                    Console.WriteLine("----------------------------------------");
                    Matriz.mostra(matriz2);
                    Console.WriteLine("----------------------------------------");
                    break;

                case 'e':
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
