using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConBuenDiseño
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee supervisor = new Supervisor();

            double salary = supervisor.CalculateSalary();

            SellerByCommision sellerByCommision = new SellerByCommision(20);

            double salary2 = sellerByCommision.CalculateSalary();

            Console.WriteLine(salary);
        }
    }

    abstract class Employee
    {
        public abstract double CalculateSalary();        
    }

    class Administrative : Employee
    {
        public override double CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Supervisor : Employee
    {
        public override double CalculateSalary()
        {
            return 20000;
        }
    }

    class Manager : Employee
    {
        public override double CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Seller : Employee
    {
        public override double CalculateSalary()
        {
            return 30000;
        }
    }

    class SellerByCommision : Seller
    {
        int count;

        public SellerByCommision(int count)
        {
            this.count = count;
        }

        public override double CalculateSalary()
        {
            return 20000 + (100 * count);
        }
    }
}
