namespace Grafos;

public class Graph<T>
{
    private Dictionary<T, List<T>> adjacencyList = new();

    public void AddVertex(T vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
        {
            adjacencyList.Add(vertex, new List<T>());
        }
    }

    public void AddEdge(T src, T dst)
    {
        AddVertex(src);
        AddVertex(dst);
        adjacencyList[src].Add(dst);
    }

    public List<T> BFS(T start)
    {
        List<T> visited = new();
        Queue<T> queue = new();
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            T node = queue.Dequeue();

            if (!visited.Contains(node))
            {
                visited.Add(node);

                foreach (var neighbor in adjacencyList[node])
                {
                    queue.Enqueue(neighbor);
                }
            }
        }

        return visited;
    }
}

class Program
{
    static void Main()
    {
        var graph = new Graph<string>();
        graph.AddEdge("vc", "Joanilsda");
        graph.AddEdge("vc", "Carlendson");
        graph.AddEdge("vc", "Danisvardo");
        graph.AddEdge("vc", "Cleonistica");
        graph.AddEdge("vc", "Marlindston");
        graph.AddEdge("Joanilsda", "Cleonistica");
        graph.AddEdge("Joanilsda", "Marlindston");
        graph.AddEdge("Carlendson", "Anistilgides");
        graph.AddEdge("Carlendson", "Gabrandeia");
        graph.AddEdge("Danisvardo", "Cleonistica");
        graph.AddEdge("Cleonistica", "Marlindston");

        var bfsResult = graph.BFS("vc");
        foreach (var vertex in bfsResult)
        {
            Console.WriteLine(vertex);
        }
    }
}
