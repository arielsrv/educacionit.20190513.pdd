using System;
using System.Collections;
using System.Collections.Generic;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Colección de numeros
            List<int> values = new List<int> { 2, 3, 4, 9, 1, 0 };
            
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }

            // Colección de cadenas
            List<string> participants = new List<string> { "Ariel", "Profe", "Emmanuel", "Oscar" };
            foreach (string participant in participants)
            {
                Console.WriteLine(participant);
            }

            IEnumerator<string> enumerator = participants.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            MyCollection<int> collection = new MyCollection<int>();
            collection.Add(1);
            collection.Add(5);
            collection.Add(3);
            collection.Add(2);
            collection.Add(9);            

            foreach (int value in collection)
            {
                Console.WriteLine(value);
            }

            //MyCollection collection = new MyCollection();
            //foreach (object value in collection)
            //{
            //    int n = (int) value;
            //    Console.WriteLine(n);
            //}            
        }
    }

    class MyIntCollection
    {

    }

    class MyStringCollection
    {

    }


    class MyCollection<T> : IEnumerable<T>
    {
        private Node<T> head = null;

        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> current = head;
                while (current.GetNext() != null)
                {
                    current = current.GetNext();
                }
                current.SetNext(node);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;

            while (current != null)
            {
                yield return current.GetValue();
                current = current.GetNext();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class Node<T>
    {
        private T value;
        private Node<T> next;

        public Node(T value)
        {
            this.value = value;
        }

        public Node<T> GetNext()
        {
            return this.next;
        }

        public void SetNext(Node<T> node)
        {
            this.next = node;
        }

        public T GetValue()
        {
            return this.value;
        }
    }
}
