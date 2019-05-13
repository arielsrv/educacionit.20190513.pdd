using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee supervisor = new Employee(EmployeeType.Seller);

            Calculator calculator = new Calculator();

            double salary = calculator.Calculate(supervisor, 0);

            Console.WriteLine(salary);
            Console.ReadKey();
        }
    }

    class Calculator
    {
        public double Calculate(Employee employee, int count)
        {
            switch (employee.GetEmployeeType())
            {
                case EmployeeType.Administrative:
                    return 10000;
                case EmployeeType.Supervisor:
                    return 20000;
                case EmployeeType.Manager:
                    return 50000;
                case EmployeeType.Seller:
                    return 30000;
                case EmployeeType.SellerByCommission:
                    return 20000 + CalculateCommissions(count);
                default:
                    throw new ApplicationException("Employee type is invalid");
            }
        }

        private int CalculateCommissions(int count)
        {
            int k = 100;

            return k * count;
        }
    }


    class Employee
    {
        private double salary;
        private EmployeeType type;

        public Employee(EmployeeType type)
        {
            this.type = type;
        }

        public EmployeeType GetEmployeeType()
        {
            return this.type;
        }

        public double GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
    }

    enum EmployeeType
    {
        Administrative,
        Supervisor,
        Manager,
        Seller,
        SellerByCommission
    }


}
