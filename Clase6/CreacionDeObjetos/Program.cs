using System;
using System.Collections.Generic;

namespace CreacionDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            string document = "AAABBBBBBB";

            char[] characters = document.ToCharArray();

            CharacterCreator characterCreator = new CharacterCreator();

            int size = 1;
            foreach (char character in characters)
            {                
                Character c = characterCreator.GetCharacter(character);
                c.Show(size);
                size = size + 1;
            }
        }
    }

    class CharacterCreator
    {
        // Cache (Flyweight) ¿Cómo funciona un Dictionary / HashMap / Tabla de hash?
        Dictionary<char, Character> characters = new Dictionary<char, Character>();

        public Character GetCharacter(char character)
        {
            if (characters.ContainsKey(character))
            {
                return characters[character];
            }

            Character temp;
            switch (character)
            {
                case 'A': temp = new CharacterA(); break;
                case 'B': temp = new CharacterB(); break;
                default:
                    throw new ArgumentException();
            }
            characters.Add(character, temp);

            return temp;
        }
    }


    abstract class Character
    {
        protected char symbol;
        protected int size;

        public abstract void Show(int size);
    }

    class CharacterA : Character
    {
        public CharacterA()
        {
            this.symbol = 'A';
        }

        public override void Show(int size)
        {
            Console.WriteLine($"Showing: {this.symbol}, Size: {size}");
        }
    }

    class CharacterB : Character
    {
        public CharacterB()
        {
            this.symbol = 'B';
        }

        public override void Show(int size)
        {
            Console.WriteLine($"Showing: {this.symbol}, Size: {size}");
        }
    }
}
