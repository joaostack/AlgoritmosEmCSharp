namespace BFS;

public class Graph<T>
{
    private Dictionary<T, List<T>> adjacencyList;

    public Graph()
    {
        adjacencyList = new Dictionary<T, List<T>>();
    }

    public void AddVertex(T vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
        {
            adjacencyList.Add(vertex, new List<T>());
        }
    }

    public void AddEdge(T source, T destination)
    {
        AddVertex(source);
        AddVertex(destination);

        adjacencyList[source].Add(destination);
        adjacencyList[destination].Add(source);
    }

    public List<T> GetNeighbors(T vertex)
    {
        if (adjacencyList.ContainsKey(vertex))
        {
            return adjacencyList[vertex];
        }

        return new List<T>();
    }

    public void PrintGraph()
    {
        foreach (var entry in adjacencyList)
        {
            Console.Write($"Vertex {entry.Key}: ");
            Console.WriteLine(string.Join(", ", entry.Value));
        }
    }
}

class Program
{
    static void Main()
    {
        Graph<string> peoples = new Graph<string>();
        peoples.AddVertex("Joao");
        peoples.AddVertex("Lucas");
        peoples.AddVertex("Julio");
        peoples.AddVertex("Rafael");
        peoples.AddVertex("Nathan");

        peoples.AddEdge("Joao", "Lucas");
        peoples.AddEdge("Lucas", "Julio");
        peoples.AddEdge("Joao", "Rafael");
        peoples.AddEdge("Rafael", "Nathan");

        peoples.PrintGraph();
    }
}
