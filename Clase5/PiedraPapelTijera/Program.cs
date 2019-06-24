
using System;

namespace PiedraPapelTijera
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de Double Dispatch

            Hand hand1 = new Rock();
            Hand hand2 = new Paper();

            // Primer dispatch es LoseAgainst (dependendiendo de la instancia, es este caso una Rock())
            Console.WriteLine(hand1.LoseAgainst(hand2));
        }
    }


    abstract class Hand
    {
        public abstract bool LoseAgainst(Hand hand);
        public abstract bool LoseAgainst(Rock rock);
        public abstract bool LoseAgainst(Paper paper);
        public abstract bool LoseAgainst(Scissors scissors);

        // public abstract bool LoseAgainst(Wood wood);
    }

    class Rock : Hand
    {
        public override bool LoseAgainst(Rock rock)
        {
            return false;
        }

        public override bool LoseAgainst(Paper paper)
        {
            return true;
        }

        public override bool LoseAgainst(Scissors scissors)
        {
            return false;
        }

        public override bool LoseAgainst(Hand hand)
        {
            // Segundo dispatch es LoseAgainst (dependendiendo de la instancia, es este caso una Paper())
            return !hand.LoseAgainst(this);
        }
    }

    class Paper : Hand
    {
        public override bool LoseAgainst(Rock rock)
        {
            return false;
        }

        public override bool LoseAgainst(Paper paper)
        {
            return false;
        }

        public override bool LoseAgainst(Scissors scissors)
        {
            return true;
        }

        public override bool LoseAgainst(Hand hand)
        {            
            return !hand.LoseAgainst(this);
        }
    }

    class Scissors : Hand
    {
        public override bool LoseAgainst(Rock rock)
        {
            return true;
        }

        public override bool LoseAgainst(Paper paper)
        {
            return false;
        }

        public override bool LoseAgainst(Scissors scissors)
        {
            return false;
        }

        public override bool LoseAgainst(Hand hand)
        {
            return !hand.LoseAgainst(this);
        }
    }
}
