int LinearSearch(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target)
        {
            return i; // Return the index of the target element
        }
    }

    return -1;
}

int[] numbers = { 10, 20, 30, 40, 50 };
int target = 30;
int index = LinearSearch(numbers, target);
Console.WriteLine(index != -1 ? $"Element {target} found at index: {index}" : "Element not found");