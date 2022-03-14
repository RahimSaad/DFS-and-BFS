using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_BFS
{
    class DFS<IdType,NodeType> where NodeType : IGraphNode<IdType, NodeType> , IComparable<NodeType>
    {
        Graph<IdType, NodeType> graph;
        public DFS(Graph<IdType, NodeType> graph)
        {
            this.graph = graph;
        }

        public bool hasPath(IdType src , IdType dest)
        {
            return hasPath(graph.getNode(src), graph.getNode(dest), new HashSet<IdType>());
        }

        private bool hasPath(NodeType src, NodeType dest, HashSet<IdType> visited)
        {
            Console.WriteLine("src: {0}     dest: {1}", src.getID(), dest.getID());

            if (src.CompareTo(dest) == 0) { return true; }
            visited.Add(src.getID());
            
            for (QNode<NodeType> rf = src.getNeighbours().Head; rf != null; rf = rf.next)
            {
                if (!visited.Contains(rf.Value.getID()))
                {
                    if (hasPath(rf.Value, dest, visited))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
