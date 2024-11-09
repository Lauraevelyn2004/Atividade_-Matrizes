using System;
using Biblioteca_Matriz;

class Exerciciog_9
{
    static int CalcularAreaCoberta(int[,] matriz)
    {
        int area = 0;
        int rows = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        // Contar todas as células que estão cobertas (marcadas com 1)
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] == 1)
                {
                    area++;
                }
            }
        }
        return area;
    }

    static void Main()
    {
        Console.Write("Informe o número de redes lançadas: ");
        int N = int.Parse(Console.ReadLine());
        int maxX = 0, maxY = 0;
        int[,] redes = new int[N, 4];

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"\nInforme as coordenadas da rede {i + 1}:");

            Console.Write("Digite o valor de Xi (coordenada inicial X): ");
            int xi = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Xf (coordenada final X): ");
            int xf = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Yi (coordenada inicial Y): ");
            int yi = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Yf (coordenada final Y): ");
            int yf = int.Parse(Console.ReadLine());

            redes[i, 0] = xi;
            redes[i, 1] = xf;
            redes[i, 2] = yi;
            redes[i, 3] = yf;

            maxX = Math.Max(maxX, xf);
            maxY = Math.Max(maxY, yf);
        }

        
        int[,] matriz = new int[maxX + 1, maxY + 1]; 
        Matriz.gera(matriz);

        for (int i = 0; i < N; i++)
        {
            int xi = redes[i, 0], xf = redes[i, 1], yi = redes[i, 2], yf = redes[i, 3];

            for (int x = xi; x <= xf; x++)
            {
                for (int y = yi; y <= yf; y++)
                {
                    matriz[x, y] = 1; // Marca como coberto
                }
            }
        }

        // Exibir a matriz de cobertura das redes de pesca
        Console.WriteLine("\nMatriz de cobertura das redes de pesca:");
        Console.WriteLine("----------------------------------------");
        Matriz.mostra(matriz);
        Console.WriteLine("----------------------------------------");
        // Calcular a área coberta
        int areaCoberta = CalcularAreaCoberta(matriz);
        Console.WriteLine($"\nÁrea total coberta pelas redes de pesca: {areaCoberta}");
    }
}
