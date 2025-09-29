int[,] matriz1 = new int[3, 3] {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int[,] matriz2 = new int[3, 3] {
    { 9, 8, 7 },
    { 6, 5, 4 },
    { 3, 2, 1 }
};

Console.WriteLine("Soma das matrizes:");
var somaMatriz = SumMatriz(matriz1, matriz2);
for (int i = 0; i < somaMatriz.GetLength(0); i++)
{
    for (int j = 0; j < somaMatriz.GetLength(1); j++)
    {
        Console.Write(somaMatriz[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Multiplicação das matrizes:");
var multMatriz = MultiplyMatriz(matriz1, matriz2);
for (int i = 0; i < multMatriz.GetLength(0); i++)
{
    for (int j = 0; j < multMatriz.GetLength(1); j++)
    {
        Console.Write(multMatriz[i, j] + " ");
    }
    Console.WriteLine();
}

/// <summary>
/// Soma valores de uma matriz
/// </summary>
int[,] SumMatriz(int[,] matriz, int[,] matriz2)
{
    int[,] result = new int[matriz.GetLength(0), matriz.GetLength(1)];
    var rows = matriz.GetLength(0);
    var cols = matriz.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[i, j] = matriz[i, j] + matriz2[i, j];
        }
    }

    return result;
}

/// <summary>
/// Multiplica valores de uma matriz
/// </summary>
int[,] MultiplyMatriz(int[,] matriz, int[,] matriz2)
{
    int[,] result = new int[matriz.GetLength(0), matriz2.GetLength(1)];
    var rows = matriz.GetLength(0);
    var cols = matriz2.GetLength(1);
    var comum = matriz.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            int soma = 0;
            for (int k = 0; k < comum; k++)
            {
                soma += matriz[i, k] * matriz2[k, j];
            }
            result[i, j] = soma;
        }
    }

    return result;
}