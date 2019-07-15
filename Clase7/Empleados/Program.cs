using System;
using System.Collections.Generic;

namespace Empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeHandler employeeHandler = new EmployeeHandler();

            employeeHandler.Add(new Employee("Juan", 20000, 14));
            employeeHandler.Add(new Employee("Jorge", 15000, 14));
            employeeHandler.Add(new Employee("Maria", 18000, 14));
            employeeHandler.Add(new Employee("Alice", 25000, 14));
            employeeHandler.Add(new Employee("Boc", 25000, 14));

            employeeHandler.Accept(new SalaryVisitor());
        }
    }

    interface IVisitor
    {
        void Visit(Employee employee);
    }

    class SalaryVisitor : IVisitor
    {
        public void Visit(Employee employee)
        {
            double current = employee.GetSalary() * 1.10;
            employee.SetSalary(current);
            Console.WriteLine($"New Salary: {current}");
        }
    }

    class Employee
    {
        private string name;
        private double salary;
        private int holidays;

        public Employee(string name, double salary, int holidays)
        {
            this.name = name;
            this.salary = salary;
            this.holidays = holidays;
        }

        public double GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    class EmployeeHandler
    {
        private List<Employee> employees = new List<Employee>();

        public void Add(Employee employee)
        {
            this.employees.Add(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Employee employee in employees)
            {
                employee.Accept(visitor);
            }
        }
    }
}
