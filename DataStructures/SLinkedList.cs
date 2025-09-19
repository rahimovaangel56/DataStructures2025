using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
#pragma warning disable
    internal class SLinkedList
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
         * вставить элемент в начало списка
         * добавить элемент в конец списка
         * добавить элемент после другого
         * 
         * удалить первый элемент
         * удалить последний элемент
         * удалить элемент по его данным
         * 
         * проверить наличие элемента
         * очистить список
         * реализовать перебор элементов
         * перевернуть
         * 
         */
    }
}
