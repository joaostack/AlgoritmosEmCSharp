using System;
using System.Collections.Generic;

public class ProblemaDoTroco
{
    public static List<int> ProblemaTroco(int centavos, List<int> trocos) {
        var total = new List<int>();
    
        foreach (var troco in trocos) {
            while (centavos >= troco) {
                centavos -= troco;
                total.Add(troco);
            }
        }    
        
        return total;
    }
    
    
    public static void Main(string[] args)
    {
        var trocos = new List<int>() { 1, 5, 7 };
        trocos.Sort();
        trocos.Reverse();
        
        var resultado = ProblemaTroco(11, trocos);
        Console.WriteLine($"Resultado = [{string.Join(", ", resultado)}]");
    }

}
