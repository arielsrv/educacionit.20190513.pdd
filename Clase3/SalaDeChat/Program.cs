using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaDeChat
{
    class Program
    {
        static void Main(string[] args)
        {            
            Participant Juan = new Participant("Juan");
            Participant Maria = new Participant("Maria");

            ChatRoom chatRoom = new ChatRoom();
            chatRoom.Join(Juan);
            chatRoom.Join(Maria);

            Juan.Send("Hola! ¿cómo estás", "Maria");
        }
    }

    class Participant
    {
        private string nickname;
        private ChatRoom chatRoom;

        public Participant(string nickname)
        {
            this.nickname = nickname;
        }

        public void SetChatRoom(ChatRoom chatRoom)
        {
            this.chatRoom = chatRoom;
        }

        public string GetName()
        {
            return this.nickname;
        }

        public void Send(string message, string to)
        {
            this.chatRoom.Send(message, this.GetName(), to);
        }

        public void Receive(string from, string message)
        {
            Console.WriteLine($"Me: Message income from {from}: {message}");
        }
    }

    class ChatRoom
    {
        Dictionary<string, Participant> participants = new Dictionary<string, Participant>();

        public void Join(Participant participant)
        {
            if (!participants.ContainsKey(participant.GetName()))
            {
                participants.Add(participant.GetName(), participant);
                participant.SetChatRoom(this);
            }
            // throw new AlreadyJoinException();
        }

        public void Send(string message, string from, string to)
        {
            if (!participants.ContainsKey(to))
            {
                // throw new UserNotJoinedException();
            }

            Participant receiver = participants[to];

            receiver.Receive(from, message);
        }
    }
}
