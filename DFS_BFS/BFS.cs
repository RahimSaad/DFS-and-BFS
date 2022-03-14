using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_BFS
{
    class BFS<IdType, NodeType> where NodeType : IGraphNode<IdType, NodeType>, IComparable<NodeType>
    {
        Graph<IdType, NodeType> graph;

        public BFS(Graph<IdType, NodeType> graph)
        {
            this.graph = graph;
        }

        public bool hasPath(IdType src, IdType dest)
        {
            return hasPath(graph.getNode(src), graph.getNode(dest));
        }
        

        private bool hasPath(NodeType src, NodeType dest)
        {
            HashSet<IdType> visited = new HashSet<IdType>();
            QLinkedList<NodeType> Q = new QLinkedList<NodeType>();
            if (src.CompareTo(dest) == 0) { return true; }
            Q.addNode(src);
            visited.Add(src.getID());

            while (!Q.isEmpty())
            {
                NodeType node = Q.pollFirst();
                for (QNode<NodeType> rf = node.getNeighbours().Head; rf != null; rf = rf.next)
                {
                    if (!visited.Contains(rf.Value.getID()))
                    {
                        Console.WriteLine(rf.Value.getID());
                        if (rf.Value.CompareTo(dest) == 0) { return true; }
                        Q.addNode(rf.Value);
                        visited.Add(rf.Value.getID());
                    }   
                }
            }
            return false;
        }
    }

}







