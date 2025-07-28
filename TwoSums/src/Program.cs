int[] TwoSums(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            var sum = nums[j] + nums[i];

            if (sum == target)
            {
                return new int[] { i, j };
            }
        }
    }

    return null;
}

// Sorted
var target1 = 14;
int[] numsSort1 = new int[] { 1, 2, 3, 4, 6, 8, 10 };
var result = TwoSums(numsSort1, target1);
Console.WriteLine(string.Join(", ", result));

// Unsorted
int target2 = 10;
int[] numsUnsorted = new int[] { 7, 1, 5, 3, 9 };
var result2 = TwoSums(numsUnsorted, target2);
Console.WriteLine(string.Join(", ", result2));