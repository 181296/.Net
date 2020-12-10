﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    /*Create the following classes
        Employee
           Prop	
	        string Name -> no blanks
	        int EmpNo -> readonly, autogenerated
	        short DeptNo -> > 0
	        abstract decimal Basic 
           Methods
	        abstract decimal CalcNetSalary()

        Manager : Employee
           Prop
	        string Designation -> cant be blank
	    GeneralManager : Manager
           Prop
 	        string Perks -> no validations
        CEO : Employee
              Make CalNetSalary() a sealed method

    NOTE : Overloaded constructors in all classes calling their base class constructor 
    All classes must implement IDbFunctions interface
    All classes to override the abstract members defined in the base class(Employee). Basic property to have different validation 
    in different classes.
    */

    abstract class Employee
    {
        private static int emp;
        private int EmpNo;
        private string Name;
        public decimal Basic;
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

        public abstract decimal basic { set;  get; }

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

        public abstract decimal GetNetSalary();
    }

    /*Manager : Employee
           Prop
	        string Designation -> cant be blank
    */

    class Manager : Employee
    {
        string Designation;

        public Manager(string Name, decimal Basic, short DeptNo, string Designation) : base(Name, Basic, DeptNo)
        {
            this.basic = Basic;
            this.designation = Designation;
        }

        public override decimal basic { get { return Basic; } 
            set 
            {
                if (value < 0)
                    Console.WriteLine("Invalid Basic !!!...");
                else if (value > 90000)
                    Console.WriteLine("out of range Basic !!!...");
                else
                    Basic = value;
            } 
        }

        public string designation { get; set; }

        public override decimal GetNetSalary()
        {
            return (Basic * 12);
        }
    }

    /*GeneralManager : Manager
           Prop
 	        string Perks -> no validations
    */
    class GeneralManager : Manager
    {
        string Perks;

        public GeneralManager(string Name, decimal Basic, short DeptNo, string Perks, string Designation) : base(Name, Basic, DeptNo, Designation)
        {
            this.basic = Basic;
            this.Perks = Perks;
        }

        public override decimal basic
        {
            get { return Basic; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Invalid Basic !!!...");
                else if (value > 120000)
                    Console.WriteLine("out of range Basic !!!...");
                else
                    Basic = value;
            }
        }

        public string perks { get; set; }

        public override decimal GetNetSalary()
        {
            return (Basic * 12);
        }
    }

    /*CEO : Employee
              Make CalNetSalary() a sealed method
    */
    class CEO : Employee
    {
        public CEO(string Name, short DeptNo, decimal Basic) : base(Name, DeptNo)
        {
            this.basic = Basic;
        }
        public override decimal basic { get { return Basic; }
            set 
            {
                if (value < 0)
                    Console.WriteLine("Invalid Basic !!!...");
                else if (value > 250000)
                    Console.WriteLine("out of range Basic !!!...");
                else
                    Basic = value;
            }  
        }

        public override sealed decimal GetNetSalary()
        {
            return (Basic * 12);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee m2 = new GeneralManager("Sham", 90000, 3, "Two", "GeneralManager");
            Console.WriteLine(m2.GetNetSalary());
            Console.WriteLine("empNo " + m2.empNo);

            Console.ReadLine();
        }
    }
}