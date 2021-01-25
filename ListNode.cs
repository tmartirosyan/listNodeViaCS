using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Enumerable
{
    class ListNode<T> : IEnumerable<T>
    {
        public ListNode(T item)
        {
            value = item;
        }

        public T value;
        public ListNode<T> next;
        private ListNode<T> _cuurentNode;

        public void Add(T item)
        {
            if (_cuurentNode == null)
            {
                next = new ListNode<T>(item);
                _cuurentNode = next;
            }
            else
            {
                _cuurentNode.next = new ListNode<T>(item);
                _cuurentNode = _cuurentNode.next;
            }
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this;
            while(node != null)
            {
                yield return node.value;
                node = node.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}