using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceadorDeCarga
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer loadBalancer1 = LoadBalancer.GetInstance();
            LoadBalancer loadBalancer2 = LoadBalancer.GetInstance();

            if (loadBalancer1 == loadBalancer2)
            {
                Console.WriteLine("Hay un único balanceador");
            } else
            {
                Console.WriteLine("Hay muchos balanceadores!");
            }

            Server server = loadBalancer1.GetServer();

            Console.WriteLine(server.GetAddress());
        }
    }

    class LoadBalancer
    {
        // Java sería un ArrayList
        private List<Server> servers = new List<Server>();
        private static LoadBalancer instance;
        private static object padlock = new object(); 

        private LoadBalancer()
        {
            this.servers.Add(new Server("192.168.0.2"));
            this.servers.Add(new Server("192.168.0.3"));
            this.servers.Add(new Server("192.168.0.4"));
            this.servers.Add(new Server("192.168.0.5"));
            this.servers.Add(new Server("192.168.0.6"));
        }

        public Server GetServer()
        {
            int number = new Random().Next(0, 4);
            // return servers.get(number); en Java
            return servers[number];
        }

        public static LoadBalancer GetInstance()
        {
            if (instance == null) // Double check
            {
                lock (padlock)
                {
                    if (instance == null) // Double check
                    {
                        instance = new LoadBalancer();
                    }
                }
            }

            return instance;            
        }
    }

    class Server
    {
        private string address;

        public Server(string address)
        {
            this.address = address;
        }

        public string GetAddress()
        {
            return this.address;
        }
    }
}
