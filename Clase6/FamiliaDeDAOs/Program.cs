using System;

namespace FamiliaDeDAOs
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDaoProvider daoProvider = new OracleDaoProvider();
            // AbstractDaoProvider daoProvider = new SqlServerDaoProvider();
            ProductDao productDao = daoProvider.CreateProductDao();

            // SqlCommand, SqlDataReader -> new SqlServerFactory()
            // IDbCommand, IDataReader -> new OracleServerFactory()

            // List<Product> products = productDao.GetAll();
        }
    }


    interface Dao<T>
    {
        T GetById(int id);
    }

    class UserDao : Dao<User>
    {
        public User GetById(int id)
        {
            return new User();
        }
    }

    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    abstract class AbstractDaoProvider
    {
        public abstract ProductDao CreateProductDao();
        public abstract CustomerDao CreateCustomerDao();
    }

    class OracleDaoProvider : AbstractDaoProvider
    {
        public override CustomerDao CreateCustomerDao()
        {
            return new OracleCustomerDao();
        }

        public override ProductDao CreateProductDao()
        {
            return new OracleProductDao();
        }
    }

    class SqlServerDaoProvider : AbstractDaoProvider
    {
        public override CustomerDao CreateCustomerDao()
        {
            return new SqlServerCustomerDao();
        }

        public override ProductDao CreateProductDao()
        {
            return new SqlServerProductDao();
        }
    }

    abstract class ProductDao
    {
        
    }

    abstract class CustomerDao
    {

    }

    class SqlServerProductDao : ProductDao
    {

    }

    class OracleProductDao : ProductDao
    {

    }

    class SqlServerCustomerDao : CustomerDao
    {

    }

    class OracleCustomerDao : CustomerDao
    {

    }

}
