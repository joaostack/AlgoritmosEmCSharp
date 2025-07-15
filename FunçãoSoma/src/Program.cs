int Soma(List<int> lista)
{
    var total = 0;

    foreach (var item in lista)
    {
        Console.WriteLine($"{total} + {item}");
        total += item;
    }

    return total;
}

var lista = new List<int>() { 1, 5, 30, 48, 12, 245, 32, 67 };
var total = Soma(lista);
Console.WriteLine($"Total: {total}");