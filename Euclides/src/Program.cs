namespace Euclides;

class Program
{
    static void Main()
    {
        Console.Write("N1 = ");
        var n1 = int.Parse(Console.ReadLine());

        Console.Write("N2 = ");
        var n2 = int.Parse(Console.ReadLine());

        while (n1 != n2)
        {
            if (n1 > n2)
            {
                n1 = n1 - n2;
            }
            else
            {
                n2 = n2 - n1;
            }

            Console.WriteLine($"Current Values => n1={n1} : n2={n2}");
        }

        Console.WriteLine($"MDC => {n1}");
    }
}