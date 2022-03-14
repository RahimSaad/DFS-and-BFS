using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_BFS
{
    interface IGraphNode <IdType , NodeType>
    {
        IdType getID();
        void addEdge(NodeType graphNode);
        QLinkedList<NodeType> getNeighbours();
    }
}
