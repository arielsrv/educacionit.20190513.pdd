using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int> { 1, 2, 9, 8, 2 };

            IEnumerator<int> iterator = values.GetEnumerator();
            while (iterator.MoveNext())
            {
                int value = iterator.Current;
                Console.WriteLine(value);
            }

            // Syntax sugar
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }

            MyCustomList<int> collection = new MyCustomList<int>();
            collection.Add(123);
                
            foreach (int value in collection)
            {

            }

        }
    }

    class MyCustomList<T> : IEnumerable<T>  
    {
        // Una bolsa de datos que no se que es

        public void Add(T element)
        {
            // lo pone en algun lado
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
