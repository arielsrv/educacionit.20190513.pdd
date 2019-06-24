using System;

namespace Recos
{
    // [Cache(TTL=100)]
    // [WebMethod]
    // [TableName("Person")]"
    // @Cache(TTL=100)
    // @WebService
    // @TableName("Person")
    class Program
    {
        // [Cache(TTL=100)]
        // [WebMethod]
        // [TableName("Person")]"
        static void Main(string[] args)
        {
            BaseCard card = new ComboCard(new Card());
            card.Show();
        }
    }

    abstract class BaseCard
    {
        public abstract void Show();
    }


    class Card : BaseCard
    {
        public override void Show()
        {
            Console.WriteLine("Showing card...");
        }
    }

    class ComboCard : BaseCard
    {        
        private BaseCard baseCard;
        public ComboCard(BaseCard baseCard)
        {
            this.baseCard = baseCard;
        }
        public override void Show()
        {
            Console.WriteLine("Showing free shipping...");
            this.baseCard.Show();
        }
    }
}
