using System.Collections;

// PEOPLE : VOTED?
var votes = new Hashtable();


void CheckVotes(string name)
{
    if (votes.Contains(name))
    {
        Console.WriteLine($"Go home, {name}!");
    }
    else
    {
        votes[name] = true;
        Console.WriteLine($"{name} voted!");
    }
}

CheckVotes("John");
CheckVotes("Oliver");

// Check vote again
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(new string('-', 15) + " Checking votes... " + new string('-', 15));
Console.ResetColor();

CheckVotes("John");
CheckVotes("Oliver");