using System;

namespace CopiasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Person instance1 = new Person("Jorge");
            Person instance2 = (Person) instance1.Clone();

            if (instance1 == instance2)
            {
                Console.WriteLine("Son iguales. ");
            }

            if (instance1.GetName() == instance2.GetName())
            {
                Console.WriteLine("Las referencias a nombre son iguales. ");
            }

            // Si quisieramos una clonacion profunda (o copia deep) deberiamos usar la clase BinaryFormatter o similar en Java. A esto se lo conoce
            // serializacion.
        }
    }

    class Person : ICloneable
    {
        private string name;

        public string GetName()
        {
            return this.name;
        }

        // Shallow copy
        public object Clone()
        {            
            return this.MemberwiseClone();
        }

        public Person(string name)
        {
            this.name = name;
        }
    }
}
