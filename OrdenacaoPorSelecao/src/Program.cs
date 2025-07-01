int[] OrdenacaoPorSelecao(int[] arr)
{
    // Percorrer pelo array
    for (int i = 0; i < arr.Length; i++)
    {
        // pegar o indice seguinte ao indice atual
        for (int j = i + 1; j < arr.Length; j++)
        {
            // Se o numero seguinte for maior que o indice atual, então troque o lugar do maior pelo menor
            if (arr[i] >= arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    return arr;
}

int[] numeros = { 23, 45, 34, 67, 83, 32, 56, 12, 53 };
var ordenacao = OrdenacaoPorSelecao(numeros);
Console.WriteLine($"Lista Ordenada: {string.Join(", ", ordenacao)}");