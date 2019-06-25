using System;
using System.Collections.Generic;

namespace Componentes
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite composite = new Composite("main");
            composite.Add(new Simple("simple1"));
            composite.Add(new Simple("simple2"));

            Composite composite2 = new Composite("main2");
            composite2.Add(new Simple("simple3"));

            composite.Add(composite2);
            composite.Draw();
        }
    }

    abstract class Component
    {
        protected string id;

        public Component(string id)
        {
            this.id = id;
        }

        public abstract void Draw();
    }

    class Simple : Component
    {
        public Simple(string id) : base(id)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Showing simple component. {this.id} ");
        }
    }

    class Composite : Component
    {
        private List<Component> components = new List<Component>();

        public Composite(string id) : base(id)
        {
        }

        public void Add(Component component)
        {
            this.components.Add(component);
        }

        public override void Draw()
        {
            Console.WriteLine($"Showing composite component. {this.id} ");
            foreach (Component component in components)
            {
                component.Draw();
            }
        }
    }

}
