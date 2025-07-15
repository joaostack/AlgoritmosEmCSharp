int Count(List<int> lista)
{
    if (lista.Count <= 0)
    {
        return 0;
    }
    else
    {
        return 1 + Count(lista[1..]);
    }
}

var lista = new List<int>() { 1, 3, 5, 28, 32, 2, 4, 45, 75 };
var n = Count(lista);
Console.WriteLine(n);