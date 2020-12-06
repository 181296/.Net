using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    class Employee
    {
        private static int emp;
        private int EmpNo;
        private string Name;
        private decimal Basic;
        private short DeptNo;

        public Employee()
        {
            EmpNo = ++emp;
        }

        public Employee(string Name, decimal Basic, short DeptNo)
        {
            EmpNo = ++emp;
            this.name = Name;
            this.basic = Basic;
            this.deptNo = DeptNo;
        }

        public Employee(string Name, decimal Basic)
        {
            EmpNo = ++emp;
            this.name = Name;
            this.basic = Basic;
        }

        public Employee(string Name)
        {
            EmpNo = ++emp;
            this.name = Name;
        }


        public int empNo 
        {
            get { return EmpNo; }
        }

        public string name
        {
            set
            {
                if (Equals(value, ""))
                    Console.WriteLine("Name should not be EMPTY!!!");
                else
                    Name = value;
            }

            get { return Name; }
        }

        public decimal basic
        {
            set
            {
                if (value >= 0)
                    Basic = value;
                else
                    Console.WriteLine("Basic should not be above 0");
            }

            get { return Basic; }
        }

        public short deptNo
        {
            set
            {
                if (value > 0)
                    DeptNo = value;
                else
                    Console.WriteLine("Department should not be 0 !!!");
            }

            get { return DeptNo; }
        }

        public decimal GetNetSalary()
        {
            decimal netSalary = Basic * 12;
            return netSalary;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();
            Console.WriteLine(o1.empNo);
            Console.WriteLine(o2.empNo);
            Console.WriteLine(o3.empNo);

            Console.WriteLine(o3.empNo);
            Console.WriteLine(o2.empNo);
            Console.WriteLine(o1.empNo);
            Console.ReadKey();
        }
    }
}
