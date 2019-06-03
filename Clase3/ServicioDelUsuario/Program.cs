using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioDelUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Init cache
            CacheSource<User> cacheSource = new CacheSource<User>();
            cacheSource.Insert(123, new User
            {
                Id = 123,
                FirstName = "Jorge",
                LastName = "Sanchez"
            });

            #endregion            

            UserService userService = new UserService(cacheSource);

            // NotificacionService notificationServie = new NotificationService()
            // UserService userService = new UserService(cacheSource);
            // notifactionService.Send(123);

            // RewardsService rewardsService = new RewardService()
            // UserService userService = new UserService(dbSource);
            // rewardsService.ProcessReward(123);

            User user = userService.Get(123);

            User anotherUser = userService.Get(123, new DbSource<User>());

            Console.WriteLine(user.FirstName);
        }
    }

    interface IReadable<T>
    {
        T Get(int id);
    }

    class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class UserService : IReadable<User>
    {
        IDataSource<User> dataSource;

        public UserService(IDataSource<User> dataSource)
        {
            this.dataSource = dataSource;
        }

        public User Get(int id)
        {
            return dataSource.Get(123);
        }

        public User Get(int id, IDataSource<User> dataSource)
        {
            return dataSource.Get(id);
        }

        public User Get(int id, bool dbEnable = true)
        {
            if (dbEnable)
            {
                // Hago una cosa 
            }
            else
            {
                // Hago otra
            }
            return null;
        }
    }

    interface IDataSource<T> : IReadable<T>
    {        
    }

    class CacheSource<T> : IDataSource<T>
    {
        // HashMap<int, T> values en Java
        readonly IDictionary<int, T> values = new Dictionary<int, T>();

        public void Insert(int key, T value)
        {
            this.values.Add(key, value);
        }

        public T Get(int id)
        {
            // values.get(id) similar a Java
            return values[id];
        }
    }

    class DbSource<T> : IDataSource<T>
    {
        public T Get(int id)
        {
            // JDBC, Hibernate, ADODb, ADO .NET
            throw new NotImplementedException();
        }
    }





























































    class MyClassAutoPropiedad
    {
        private string _name;

        public void set_Name(string _name)
        {
            this._name = _name;
        }

        public string get_Name()
        {
            return this._name;
        }
    }

    class MyClassConAutoPropiedad
    {
        public string Name { get; set; }

        // MyClassConAutoPropiedad instancia = new ....
        // instancia.Name = "Ariel" equivale instancia.set_Name("Ariel"); 
        // SysOut(instancia.Name) == SysOut(instancia.get_Name())
    }
}
