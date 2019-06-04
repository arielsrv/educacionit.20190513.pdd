using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            API facebookAPI = new FacebookAPI(new VoiceSender());
            facebookAPI.Send("Hola. ¿Cómo estás?");
        }
    }

    abstract class API
    {
        protected Sender sender;

        public API(Sender sender)
        {
            this.sender = sender;
        }

        public abstract void Send(string message);
    }

    class FacebookAPI : API
    {
        public FacebookAPI(Sender sender) : base(sender)
        {
        }

        public override void Send(string message)
        {
            // this.sender.Send(message);
        }
    }

    class TwitterAPI : API
    {
        public TwitterAPI(Sender sender) : base(sender)
        {
        }

        public override void Send(string message)
        {
            throw new NotImplementedException();
        }
    }

    class Sender
    {

    }

    class VoiceSender : Sender
    {

    }

    class TextSender : Sender
    {

    }
}
