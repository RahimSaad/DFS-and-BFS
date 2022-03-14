using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_BFS
{
    class Graph<IdType,NodeType> where NodeType : IGraphNode<IdType, NodeType>
    {
        Dictionary<IdType, NodeType> graph;

        public Graph()
        {
            graph = new Dictionary<IdType, NodeType>();
        }

        public void addNode(NodeType node)
        {
            graph.Add(node.getID(), node);
        }

        public NodeType getNode(IdType key)
        {
            if (!graph.ContainsKey(key)) { throw new Exception("no such a node with that key"); }
            return graph[key];
        }

        public void addEdge(IdType source, IdType destination)
        {
            NodeType srcNode = getNode(source);
            NodeType destNode = getNode(destination);
            srcNode.addEdge(destNode);
            destNode.addEdge(srcNode);
        }

    }
}
