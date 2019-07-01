using System;
using System.Collections.Generic;

namespace BalanceadorDeCarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Singleton<LoadBalancer> loadBalancer = new Singleton<LoadBalancer>();
            // loadBalancer.GetInstance();

            // Lazy<LoadBalancer> loadBalancer = new Lazy<LoadBalancer>();
            // LoadBalancer loadBalancer = loadBalancer.Value;
        }
    }

    class Singleton<T>
    {
        public static T GetInstance()
        {
            // return instance;
            return default(T);
        }
    }


    // Ejemplo Singleton optimizado para C# (muy similar en Java)

    class LoadBalancer
    {
        // Java sería un ArrayList
        private List<Server> servers = new List<Server>();
        private readonly static LoadBalancer instance = new LoadBalancer();        

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
