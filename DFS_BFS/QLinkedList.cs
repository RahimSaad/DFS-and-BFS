using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_BFS
{
    class QLinkedList<T>
    {
        private QNode<T> head, tail;
        private int size;
        public int Size { get => size; }
        public QNode<T> Head { get => head; }
        public QNode<T> Tail { get => tail; }

        public QLinkedList()
        {
            this.size = 0;
        }

        public bool isEmpty()
        {
            return head == null;
        }
        public void addNode(T value)
        {
            QNode<T> node = new QNode<T>(value, null);
            if (head == null) { head = node; tail = node; }
            else
            {
                tail.next = node;
                tail = node;
            }
            this.size++;
        }
        public T pollFirst()
        {
            if (head == null) { throw new Exception("list is empty"); }
            T tmp = head.Value;
            head = head.next;
            return tmp;
        }

    }
}
