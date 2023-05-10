namespace ShortesPathAlgorithm
{
    /*
     * In this example, we define a Graph class with an adjacency list representation. 
     * The AddEdge method is used to add edges to the graph, 
     * and the DijkstraShortestPath method implements Dijkstra's algorithm 
     * to calculate the shortest path from a given source vertex. 
     * The MinimumDistance helper method is used to find the vertex with 
     * the minimum distance among the unvisited vertices.
     *
     * In the Main method, we create a graph with 6 vertices and add some edges. 
     * Then we specify the source vertex and call the DijkstraShortestPath method 
     * to calculate the distances from the source to all other vertices. 
     * Finally, we print the distances
     * 
     * There is a bug in the code. The expected outputs are given in the comments in each test case.
     * Your output should match the expected output.
     *      
     * 
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            RunTestcase1();
            RunTestcase2();
            RunTestcase3();
            RunTestcase4();
            RunTestcase5();

            Console.WriteLine("Press Any key to Return");
            Console.ReadKey();
        }

        private static void RunTestcase1()
        {
            Console.WriteLine("Testcase 1:");
            int vertices = 6;
            Graph graph = new Graph(vertices);

            graph.AddEdge(0, 1, 4);
            graph.AddEdge(0, 2, 3);
            graph.AddEdge(1, 3, 2);
            graph.AddEdge(1, 2, 1);
            graph.AddEdge(2, 3, 4);
            graph.AddEdge(3, 4, 2);
            graph.AddEdge(4, 5, 6);

            int source = 0;
            int[] distances = graph.DijkstraShortestPath(source);

            Console.WriteLine("Vertex\tDistance from Source");
            for (int i = 0; i < vertices; i++)
            {
                Console.WriteLine($"{i}\t{distances[i]}");
            }

            // Expected output:
            // Vertex  Distance from Source
            // 0       0
            // 1       4
            // 2       3
            // 3       6
            // 4       8
            // 5       14

            Console.WriteLine();
        }
        private static void RunTestcase2()
        {
            Console.WriteLine("Testcase 2:");
            int vertices = 5;
            Graph graph = new Graph(vertices);

            graph.AddEdge(0, 1, 10);
            graph.AddEdge(0, 3, 5);
            graph.AddEdge(1, 2, 1);
            graph.AddEdge(1, 3, 2);
            graph.AddEdge(2, 4, 4);
            graph.AddEdge(3, 1, 3);
            graph.AddEdge(3, 2, 9);
            graph.AddEdge(3, 4, 2);
            graph.AddEdge(4, 0, 7);
            graph.AddEdge(4, 2, 6);

            int source = 0;
            int[] distances = graph.DijkstraShortestPath(source);

            Console.WriteLine("Vertex\tDistance from Source");
            for (int i = 0; i < vertices; i++)
            {
                Console.WriteLine($"{i}\t{distances[i]}");
            }

            // Expected output:
            // Vertex  Distance from Source
            // 0       0
            // 1       7
            // 2       8
            // 3       5
            // 4       7

            Console.WriteLine();
        }
        private static void RunTestcase3()
        {
            Console.WriteLine("Testcase 3:");
            int vertices = 5;
            Graph graph = new Graph(vertices);

            graph.AddEdge(0, 1, 3);
            graph.AddEdge(0, 2, 5);
            graph.AddEdge(1, 2, 2);
            graph.AddEdge(1, 3, 6);
            graph.AddEdge(2, 3, 1);
            graph.AddEdge(2, 4, 4);
            graph.AddEdge(3, 4, 2);

            int source = 0;
            int[] distances = graph.DijkstraShortestPath(source);

            Console.WriteLine("Vertex\tDistance from Source");
            for (int i = 0; i < vertices; i++)
            {
                Console.WriteLine($"{i}\t{distances[i]}");
            }

            // Expected output:
            // Vertex  Distance from Source
            // 0       0
            // 1       3
            // 2       5
            // 3       6
            // 4       8

            Console.WriteLine();
        }
        private static void RunTestcase4()
        {
            Console.WriteLine("Testcase 4:");
            int vertices = 3;
            Graph graph = new Graph(vertices);

            graph.AddEdge(0, 1, 2);
            graph.AddEdge(1, 2, 3);
            graph.AddEdge(2, 0, 1);

            int source = 1;
            int[] distances = graph.DijkstraShortestPath(source);

            Console.WriteLine("Vertex\tDistance from Source");
            for (int i = 0; i < vertices; i++)
            {
                Console.WriteLine($"{i}\t{distances[i]}");
            }

            // Expected output:
            // Vertex  Distance from Source
            // 0       2
            // 1       0
            // 2       3

            Console.WriteLine();
        }
        private static void RunTestcase5()
        {
            Console.WriteLine("Testcase 5:");
            int vertices = 4;
            Graph graph = new Graph(vertices);

            graph.AddEdge(0, 1, 1);
            graph.AddEdge(0, 3, 3);
            graph.AddEdge(1, 2, 2);
            graph.AddEdge(2, 3, 1);

            int source = 3;
            int[] distances = graph.DijkstraShortestPath(source);

            Console.WriteLine("Vertex\tDistance from Source");
            for (int i = 0; i < vertices; i++)
            {
                Console.WriteLine($"{i}\t{distances[i]}");
            }

            // Expected output:
            // Vertex  Distance from Source
            // 0       3
            // 1       3
            // 2       1
            // 3       0

            Console.WriteLine();
        }
    }
    public class Graph
    {
        private int vertices;
        private List<Tuple<int, int>>[] adjacencyList;

        public Graph(int vertices)
        {
            this.vertices = vertices;
            adjacencyList = new List<Tuple<int, int>>[vertices];

            for (int i = 0; i < vertices; i++)
            {
                adjacencyList[i] = new List<Tuple<int, int>>();
            }
        }

        public void AddEdge(int source, int destination, int weight)
        {
            adjacencyList[source].Add(new Tuple<int, int>(destination, weight));
            adjacencyList[destination].Add(new Tuple<int, int>(source, weight));
        }

        public int[] DijkstraShortestPath(int source)
        {
            int[] distances = new int[vertices];
            bool[] visited = new bool[vertices];

            for (int i = 0; i < vertices; i++)
            {
                distances[i] = int.MaxValue;
                visited[i] = false;
            }

            distances[source] = 0;

            for (int count = 0; count < vertices - 1; count++)
            {
                int u = MinimumDistance(distances, visited);
                visited[u] = true;

                foreach (var neighbor in adjacencyList[u])
                {
                    int v = neighbor.Item1;
                    int weight = neighbor.Item2;

                    if (!visited[v] && distances[u] != int.MaxValue && distances[u] + weight < distances[v])
                    {
                        distances[v] = distances[u] + weight;
                    }
                }
            }

            return distances;
        }

        private int MinimumDistance(int[] distances, bool[] visited)
        {
            int minDistance = int.MaxValue;
            int minIndex = -1;

            for (int v = 0; v < vertices; v++)
            {
                if (!visited[v] && distances[v] <= minDistance)
                {
                    minDistance = distances[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
    }
}