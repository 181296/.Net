using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    /*1. Declare a dictionary based collection of Employee class objects 
        
        Accept details for Employees  in a loop. Stop accepting based on user input (yes/no)'
        Display the Employee with highest Salary
        Accept EmpNo to be searched. Display all details for that employee.
        Display details for the Nth Employee where N is a number accepted from the user.
    */
    class Employee
    {
        private int EmpNo;
        private string Name;
        private decimal Basic;
        private short DeptNo;

        public Employee()
        {

        }

        public Employee(int EmpNo, string Name, decimal Basic, short DeptNo)
        {
            this.empNo = EmpNo;
            this.name = Name;
            this.basic = Basic;
            this.deptNo = DeptNo;
        }

        public Employee(int EmpNo, string Name, decimal Basic)
        {
            this.empNo = EmpNo;
            this.name = Name;
            this.basic = Basic;
        }

        public Employee(int EmpNo, string Name)
        {
            this.empNo = EmpNo;
            this.name = Name;
        }


        public int empNo
        {
            set
            {
                if (value > 0)
                    EmpNo = value;
                else
                    Console.WriteLine("Employee should above 0");
            }

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

        public override string ToString()
        {
            return "\nEmployee_ID : " + empNo + " " + "\nName : " + name + "Department No. : " + deptNo + "\nBasic : " + basic + "\n";
        }

    }

    class Program
    {
        static void Main1(string[] args)
        {
            int i = 1;
            Console.Write("\nInput -> (Y/N) : ");
            char ch = Convert.ToChar(Console.ReadLine());
            Dictionary<int, Employee> dicEmp = new Dictionary<int, Employee>();
            while (ch != 'N')
            {
                Console.WriteLine("\nEnter Employee Details ...");
                Console.Write("\nEmployee_ID : ");
                int em = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nName : ");
                string name = Console.ReadLine();
                Console.Write("\nDepartment : ");
                short d = (short)Convert.ToInt32(Console.ReadLine());
                Console.Write("\nBasic : ");
                decimal b = Convert.ToDecimal(Console.ReadLine());
                dicEmp.Add(i++, new Employee(em, name, b, d));
                Console.Write("\nInput -> (Y/N) : ");
                ch = Convert.ToChar(Console.ReadLine());

            }

            /*for (int k = 0; k < dicEmp.Count; k++)
            {
                Console.WriteLine("\nKey: {0}, Value: {1}",
                                                        dicEmp.ElementAt(k).Key,
                                                        dicEmp.ElementAt(k).Value.ToString());
            }*/
            //Highest Salary
            Console.WriteLine("Employee with Highest Salary : ");
            decimal max = 0;
            Employee e = new Employee();
            for (int k = 0; k < dicEmp.Count; k++)
            {
                decimal sal = dicEmp.ElementAt(k).Value.basic;
                if (sal > max)
                {
                    max = sal;
                    e = dicEmp.ElementAt(k).Value;
                }
            }
            Console.WriteLine("\nEmployee_ID : " + e.empNo + "\nName : " + e.name + "\nDepartment : " + e.deptNo + "\nBasic : " + e.basic);

            // Search with Employee_Id
            Console.WriteLine("\n\nEnter Employee_Id : ");
            int emp = Convert.ToInt32(Console.ReadLine());
            for (int k = 0; k < dicEmp.Count; k++)
            {
                int s = dicEmp.ElementAt(k).Value.empNo;
                if (s == emp)
                {
                    e = dicEmp.ElementAt(k).Value;
                    Console.WriteLine("Employee_ID : " + e.empNo + "\nName : " + e.name + "\nDepartment : " + e.deptNo + "\nBasic : " + e.basic);
                    break;
                }
            }

            //Nth entry
            Console.WriteLine("\n\nEnter Nth Employee : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if ((dicEmp.Count >= n) && (n > -1))
            {

                e = dicEmp.ElementAt(n).Value;
                Console.WriteLine("Employee_ID : " + e.empNo + "\nName : " + e.name + "\nDepartment : " + e.deptNo + "\nBasic : " + e.basic);
            }

            Console.ReadLine();
        }
    }
}


namespace Question_2
{
    /*
        2. Create an array of Employee objects. Convert it to a List<Employee>.  Display all the Employees in the list.
    */
    class Employee
    {
        private int EmpNo;
        private string Name;
        private decimal Basic;
        private short DeptNo;

        public Employee()
        {

        }

        public Employee(int EmpNo, string Name, decimal Basic, short DeptNo)
        {
            this.empNo = EmpNo;
            this.name = Name;
            this.basic = Basic;
            this.deptNo = DeptNo;
        }

        public Employee(int EmpNo, string Name, decimal Basic)
        {
            this.empNo = EmpNo;
            this.name = Name;
            this.basic = Basic;
        }

        public Employee(int EmpNo, string Name)
        {
            this.empNo = EmpNo;
            this.name = Name;
        }


        public int empNo
        {
            set
            {
                if (value > 0)
                    EmpNo = value;
                else
                    Console.WriteLine("Employee should above 0");
            }

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

        public override string ToString()
        {
            return "\nEmployee_ID : " + empNo + " " + "\nName : " + name + "Department No. : " + deptNo + "\nBasic : " + basic + "\n";
        }

    }

    class Program
    {
        public static void Main2()
        {
            Console.WriteLine("Enter Number of Employees : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Employee[] e = new Employee[n];
            Console.WriteLine("Employee Entry : \n");
            for(int i=0; i<e.Length; i++)
            {
                Console.WriteLine("\nEmployee_ID : ");
                int emp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name : ");
                string nm = Console.ReadLine();
                Console.WriteLine("Basic : ");
                decimal b = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Department_No. : ");
                short d = (short)Convert.ToInt32(Console.ReadLine());

                e[i] = new Employee(emp, nm, b, d);
            }
            
            //List<int> list = e.ToList();
            List<Employee> le = e.ToList();
            Console.WriteLine("\nList of Employees : \n");
            for(int i=0; i<le.Count; i++)
            {
                Console.WriteLine("\n\nEmployee_ID : " + le[i].empNo + "\nName : " + le[i].name + "\nDepartment : " + le[i].deptNo + "\nBasic : " + le[i].basic);

            }

            Console.ReadLine();
        }
    }
}


namespace Question_3
{
    /*
        3. Create a List<Employee>.Convert it to an array.Display all the array elements.
    */
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter Number of Employees : ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Question_1.Employee> e = new List<Question_1.Employee>();
            
            Console.WriteLine("Employee Entry : \n\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEmployee_ID : ");
                int emp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name : ");
                string nm = Console.ReadLine();
                Console.WriteLine("Basic : ");
                decimal b = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Department_No. : ");
                short d = (short)Convert.ToInt32(Console.ReadLine());

                e.Add(new Question_1.Employee(emp, nm, b, d));
            }

            //List<int> list = e.ToList();
            Question_1.Employee[] le = e.ToArray();
            Console.WriteLine("\n\nArray of Employees : ");
            for (int i = 0; i < le.Length; i++)
            {
                Console.WriteLine("\n\nEmployee_ID : " + le[i].empNo + "\nName : " + le[i].name + "\nDepartment : " + le[i].deptNo + "\nBasic : " + le[i].basic);

            }

            Console.ReadLine();
        }
    }
}
