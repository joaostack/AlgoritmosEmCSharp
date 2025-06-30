int BuscaBinaria(int[] arquivo, int target)
{
    try
    {
        int left = 0;
        int right = arquivo.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (target == arquivo[mid])
            {
                return mid;
            }
            else if (arquivo[mid] > target)
            {
                right = mid - 1;
            }
            else if (arquivo[mid] < target)
            {
                left = mid + 1;
            }
        }

        return -0;
    }
    catch (Exception ex)
    {
        throw new Exception(ex.Message);
    }
}

try
{
    int valor = 17;
    var content = File.ReadAllLines("src/dados.txt");
    int[] intArray = Array.ConvertAll(content, int.Parse);

    var res = BuscaBinaria(intArray, valor);
    if (res != -0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Valor {valor} encontrado na posição: {res}");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Valor {valor} não encontrado!");
    }
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
}
finally
{
    Console.ResetColor();
}