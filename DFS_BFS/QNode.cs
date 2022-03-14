using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_BFS
{
    class QNode<T>
    {
        public T Value;
        public QNode<T> next;
        public QNode(T value, QNode<T> next)
        {
            this.Value = value;
            this.next = next;
        }
    }
}
