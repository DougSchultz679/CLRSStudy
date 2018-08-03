using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudy.DataStructureProtos
{
    class MyLinkedList<T> where T : IComparable
    {
        public NodeSLL<T> Head;

        public MyLinkedList()
        {
            Head = null;
        }

        public int Count()
        {
            if (this.Head == null) return 0;
            int ctr = 1;
            NodeSLL<T> tmp = this.Head;
            while (tmp.Next != null)
            {
                tmp = tmp.Next;
                ctr++;
            }
            return ctr;
        }

        public bool IsEmpty()
        {
            return Head == null ? true : false;
        }

        public T GetFirst()
        {
            return Head.Data;
        }

        public T GetLast()
        {
            try
            {
                NodeSLL<T> tmp = Head;
                while (tmp.Next != null) tmp = tmp.Next;
                return tmp.Data;
            } catch
            {
                throw new ArgumentNullException();
            }
        }

        public void AddFirst(T data)
        {
            Head = new NodeSLL<T>(data, this.Head);
        }

        public void AddLast(T data)
        {
            if (Head == null)
            {
                this.AddFirst(data);
            } else
            {
                var tmp = Head;
                while (tmp.Next != null) tmp = tmp.Next;
                tmp.Next = new NodeSLL<T>(data, null);
            }
        }

        public void AddAfter(T key, T input)
        {
            NodeSLL<T> tmp = Head;
            while (tmp.Data.CompareTo(key) != 0 && tmp.Next != null) tmp = tmp.Next;
            if (tmp != null && tmp.Data.CompareTo(key) == 0) tmp.Next = new NodeSLL<T>(input, tmp.Next);
        }

        public void AddBefore(T key, T input)
        {
            if (this.Head == null) return;
            //handle insert before head
            if (Head.Data.CompareTo(key) == 0)
            {
                this.AddFirst(input);
            } else
            // handle insertions after head
            {
                NodeSLL<T> tmp = Head;
                while (tmp.Next != null && tmp.Next.Data.CompareTo(key) != 0) tmp = tmp.Next;

                //handle miss
                if (tmp.Next == null && tmp.Data.CompareTo(key) != 0) return;
                
                //do insert
                tmp.Next = new NodeSLL<T>(input, tmp.Next);
            }
        }

        public void DeleteAt(T key)
        {
            if (this.Head == null) return;
            //handle head deletions. 
            else if (Head.Data.CompareTo(key) == 0) Head = Head.Next;
            else
            {
                //handle deletions from middle. 
                NodeSLL<T> tmp = Head;
                while (tmp.Next != null && tmp.Next.Data.CompareTo(key) != 0) tmp = tmp.Next;

                //handle miss
                if (tmp.Next == null) return;

                tmp.Next = tmp.Next.Next;
            }
        }

        public void Reverse()
        {
            NodeSLL<T> curr = Head;
            NodeSLL<T> prev = null;
            NodeSLL<T> currPtr = null; 

            while (curr != null)
            {
                currPtr = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = currPtr;
            }
            this.Head = prev;
        }
    }

    //member of a singly linked list
    class NodeSLL<T> where T : IComparable
    {
        public T Data;
        public NodeSLL<T> Next;

        public NodeSLL(T data, NodeSLL<T> next)
        {
            this.Data = data;
            this.Next = next;
        }
    }
}
