using System;

namespace Traductor
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Target();
            target.Request();
        }
    }

    // Alumno
    class Target 
    {
        Adapter adapter = new Adapter();

        public void Request()
        {
            adapter.Request();
        }
    }

    // Han Solo
    class Adapter
    {
        // Conoce a Chewie
        Adaptee adaptee = new Adaptee();

        // Response al alumno
        public Target Request()
        {
            // Habla con el mundo de Chewie
            RAdaptee rAdaptee = adaptee.Request();
            return new Target();            
        }
    }

    // Chewie (SDK, Framework, Librería externa, SDK de Facebook)
    class Adaptee
    {
        public RAdaptee Request()
        {
            return new RAdaptee();
        }
    }

    class RAdaptee
    {

    }
}
