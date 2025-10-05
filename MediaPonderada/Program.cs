using System.Reflection.Emit;

List<string[]> LerDados(string path)
{
    List<string[]> rows = new List<string[]>();

    try
    {
        string[] lines = File.ReadAllLines(path);
        foreach (var line in lines)
        {
            string[] value = line.Split(',');
            rows.Add(value);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    return rows;
}

var rows = LerDados("notas_alunos.csv");
var aprovados = new List<string>();
var reprovados = new List<string>();

foreach (var row in rows.Skip(1))
{
    var nomeAluno = row[0];
    var notaPresenca = double.Parse(row[1]);
    var pesoPresenca = double.Parse(row[4]);
    var notaProva = double.Parse(row[2]);
    var pesoProva = double.Parse(row[5]);
    var notaTrabalhos = double.Parse(row[3]);
    var pesoTrabalhos = double.Parse(row[6]);

    var mp = (notaPresenca * pesoPresenca) + (notaTrabalhos * pesoTrabalhos) + (notaProva * pesoProva);
    if (mp >= 7.0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{nomeAluno} passou com a média = {Math.Round(mp)}");
        Console.ResetColor();
        aprovados.Add(nomeAluno);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{nomeAluno} reprovou com a média = {Math.Round(mp)}");
        Console.ResetColor();
        reprovados.Add(nomeAluno);
    }
}

var totalAlunos = rows.Count - 1;
double totalAlunosAprovados = aprovados.Count();
double totalAlunosReprovados = reprovados.Count();
double porcentagemAprovados = (totalAlunosAprovados / totalAlunos) * 100;
double porcentagemReprovados = (totalAlunosReprovados / totalAlunos) * 100;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Porcentagem dos aprovados = {porcentagemAprovados}%");
Console.WriteLine($"Porcentagem dos reprovados = {porcentagemReprovados}%");
Console.ResetColor();