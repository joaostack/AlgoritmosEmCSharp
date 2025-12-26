namespace ShuntingYard;

class Program
{
    static void Main()
    {
        var stupidExpression = "3+4*2/(1-5)^2";
        var res = ShuntingYard(stupidExpression);
        Console.WriteLine($"{string.Join(' ', res)}");
    }

    static Queue<string> ShuntingYard(string expression)
    {
        var output = new Queue<string>();
        var operators = new Stack<string>();

        foreach (var c in expression)
        {
            if (char.IsLetterOrDigit(c))
            {
                output.Enqueue(c.ToString());
            }
            else if (c == '(')
            {
                operators.Push(c.ToString());
            }
            else if (c == ')')
            {
                while (operators.Any() && operators.Peek() != "(")
                {
                    output.Enqueue(operators.Pop());
                }

                operators.Pop();
            }
            else
            {
                while (operators.Any() && operators.Peek() != "(" && GetPrecedence(c.ToString()) <= GetPrecedence(operators.Peek()))
                {
                    output.Enqueue(operators.Pop());
                }

                operators.Push(c.ToString());
            }
        }

        while (operators.Any())
        {
            output.Enqueue(operators.Pop());
        }

        return output;
    }

    static int GetPrecedence(string op) => op switch
    {
        "+" or "-" => 1,
        "*" or "/" => 2,
        "^" => 3,
        _ => 0
    };
}