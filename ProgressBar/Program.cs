// Linear progress bar
for (float i = 0; i < 500; i++)
{
    Console.Clear();
    float progress = (i / 500) * 100;
    Console.Write($"\rProgress: {Math.Round(progress)}%");
    Thread.Sleep(5);
}
Console.WriteLine("\nTask 1 Completed!");

Thread.Sleep(1000);

// Logarithmic progress bar
float GetBaseLog(float b, float a)
{
    return MathF.Log(a) / MathF.Log(b);
}

for (float i = 0; i < 500; i++)
{
    Console.Clear();
    float progress = GetBaseLog(500, i) * 100;
    Console.Write($"\rProgress: {Math.Round(progress)}%");
    Thread.Sleep(5);
}
Console.WriteLine("\nTask 2 Completed!");