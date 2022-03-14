using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_BFS
{
    class GNode<idType> : IGraphNode<idType, GNode<idType>> , IComparable<GNode<idType>> where idType : IComparable
    {
        public idType id;
        QLinkedList<GNode<idType>> neighbours;

        public GNode(idType id)
        {
            this.id = id;
            neighbours = new QLinkedList<GNode<idType>>();
        }

        public void addEdge(GNode<idType> node)
        {
            this.neighbours.addNode(node);
        }

        public int CompareTo(GNode<idType> other)
        {
            return this.id.CompareTo(other.id);
        }

        public idType getID()
        {
            return this.id;
        }

        public QLinkedList<GNode<idType>> getNeighbours()
        {
            return this.neighbours;
        }
        
    }
}
