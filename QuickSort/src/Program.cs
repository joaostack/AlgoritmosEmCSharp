int[] QuickSort(int[] arr)
{
    if (arr.Length <= 1)
    {
        return arr;
    }
    else
    {
        var pivo = arr[arr.Length / 2];
        var left = arr.Where(x => x < pivo).ToArray();
        var right = arr.Where(x => x > pivo).ToArray();
        var middle = arr.Where(x => x == pivo).ToArray();

        return QuickSort(left).Concat(middle).Concat(QuickSort(right)).ToArray();
    }
}

int[] arr = [10, 7, 8, 9, 1, 5];
arr = QuickSort(arr);
Console.WriteLine($"Sorted: {string.Join(",", arr)}");