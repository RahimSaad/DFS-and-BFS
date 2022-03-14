using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_BFS
{
    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DFS");
            Console.WriteLine("______________________________________");
            DFS_Test();

            Console.WriteLine("**********************************************");

            Console.WriteLine("BFS");
            Console.WriteLine("______________________________________");
            BFS_Test();
            
        }

        private static void BFS_Test()
        {
            Graph<string, GNode<string>> graph = new Graph<string, GNode<string>>();

            graph.addNode(new GNode<string>("A"));
            graph.addNode(new GNode<string>("B"));
            graph.addNode(new GNode<string>("C"));
            graph.addNode(new GNode<string>("D"));
            graph.addNode(new GNode<string>("E"));
            graph.addNode(new GNode<string>("F"));
            graph.addNode(new GNode<string>("G"));
        
            graph.addEdge("A", "B");
            graph.addEdge("A", "C");
            graph.addEdge("A", "G");

            graph.addEdge("B", "A");
            graph.addEdge("B", "D");
            graph.addEdge("B", "E");

            graph.addEdge("C", "A");
            graph.addEdge("C", "D");
            graph.addEdge("C", "G");

            graph.addEdge("D", "E");
            graph.addEdge("D", "B");
            graph.addEdge("D", "C");
            graph.addEdge("D", "F");

            graph.addEdge("E", "B");
            graph.addEdge("E", "D");

            graph.addEdge("F", "D");
            graph.addEdge("F", "G");

            graph.addEdge("G", "A");
            graph.addEdge("G", "C");
            graph.addEdge("G", "F");

            BFS<string, GNode<string>> bfs = new BFS<string, GNode<string>>(graph);
            Console.WriteLine("Has Path from A to D = {0}", bfs.hasPath("A", "E") + "\n");

        }

        private static void DFS_Test()
        {
            Graph<string, GNode<string>> graph = new Graph<string, GNode<string>>();

            graph.addNode(new GNode<string>("A"));
            graph.addNode(new GNode<string>("B"));
            graph.addNode(new GNode<string>("C"));
            graph.addNode(new GNode<string>("D"));
            graph.addNode(new GNode<string>("E"));
            graph.addNode(new GNode<string>("F"));

            graph.addEdge("A", "B");
            graph.addEdge("A", "C");
            graph.addEdge("B", "D");
            graph.addEdge("C", "D");
            graph.addEdge("D", "E");
            graph.addEdge("E", "F");

            DFS<string, GNode<string>> dfs = new DFS<string, GNode<string>>(graph);
            Console.WriteLine("Has Path from A to E = {0}", dfs.hasPath("A", "E") + "\n");
            Console.WriteLine("Has Path from A to C = {0}", dfs.hasPath("A", "C") + "\n");
            Console.WriteLine("Has Path from B to C = {0}", dfs.hasPath("B", "C") + "\n");
        }
    }
}
