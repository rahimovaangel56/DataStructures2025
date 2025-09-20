using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
#pragma warning disable
    internal class SLinkedList : IEnumerable<string>
    {
        private Node _head;
        private Node _tail;
        private int _count;

        public int Count => _count;
        public bool IsEmpty => _head == null;

        public SLinkedList()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }
        /*
         * функционал:
         * 
         * получить первый элемент
         * получить последний элемент
         * 
         * удалить первый элемент
         * удалить последний элемент
         * удалить элемент по его данным
         * 
         * проверить наличие элемента
         * перевернуть
         * 
         */

        public void AddFirst(string text)
        {
            if (text == null)
                throw new ArgumentException("данные пустые");
            Node newNode = new Node(text);
            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.Next = _head;
                _head = newNode;
            }
            _count++;
        }

        public void AddLast(string text)
        {
            if (text == null)
                throw new ArgumentException("данные пустые");
            Node newNode = new Node(text);
            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }
            _count++;
        }

        public void InsertAfter(string existingText, string text)
        {
            if (existingText == null || text == null)
                throw new ArgumentException("данные не могут быть пустые");
            Node newNode = new Node(text);
            Node current = _head;
            while (current.Next != null)
            {
                if (current.Data == existingText)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    if (current == _tail)
                        _tail = current;
                }
                current = current.Next;
            }

            _count++;
        }

        public IEnumerator<string> GetEnumerator()
        {
            Node current = _head;
            while(current != null)
            {

                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }
    }
}
