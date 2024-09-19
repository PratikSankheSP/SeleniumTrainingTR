using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard4
{
    public class Employee
    {
        private int empID;
        public string empName;
        public double empSalary;
        private string empPerformance;
        public static string companyName;

        public Employee()
        {
            Console.WriteLine("Constructor created without parameters");

        }

        public Employee(int empID, string empName)
        {
            Console.WriteLine("Constructor created with parameters");
            empID = empID;
            Console.WriteLine("EmployeeID------------"+empID);
            this.empName = empName;

        }

        public int EmployeeID
        {
            get
            {
                return empID;
            }
            set
            {
                if (value > 100)
                {
                    empID = value;
                }
                else
                {
                    Console.WriteLine("Currently Employee ID is less than 100. Please provide value more than 100.");
                }


            }
        }       

        public string EmployeePerformance
        {
            get
            {
                return empPerformance;
            }
            set
            {
                if (value.Equals("A") || value.Equals("B") || value.Equals("C"))
                {
                    empPerformance = value;
                }
                else
                {
                    Console.WriteLine("Please enter performance within A,B or C");
                }

            }
        }



        public void PrintEmployeeDetails()
        {
            empName = "Local";
            Console.WriteLine("Employee ID: " + EmployeeID);
            Console.WriteLine("Employee Name: " + this.empName); // use of this keyword to access class variables when there is clash with local varible
            Console.WriteLine("Employee Salary: " + empSalary);
            Console.WriteLine("Employee Performance: " + empPerformance);
            Console.WriteLine("Company Name: "+Employee.companyName);
            Console.WriteLine("---------------------------------------------");

        }

        public void Allocatebonus()
        {
            if (empPerformance != null)
            {
                if (empPerformance == "A")
                {
                    empSalary = empSalary + 1000;
                }
                else if (empPerformance.Equals("B"))
                {
                    empSalary = empSalary + 500;
                }
                else
                {
                    empSalary = empSalary + 100;
                }
            }


        }

        public static Employee ObjCreation() // Return type as Employee class name and object creation is moved in it specifically for static way
        {
            Employee e=new Employee();
            return e;
        }


        public static void PrintEmpDetails(Employee emp) // Employee passs as parameter which is class
        {
            Console.WriteLine(emp.empID);
            Console.WriteLine("Employee ID: " + emp.empID);
            Console.WriteLine("Employee Name: " + emp.empName);
            Console.WriteLine("Employee Salary: " + emp.empSalary);
            Console.WriteLine("Employee Performance: " + emp.empPerformance);
            Console.WriteLine("Company Name: " + Employee.companyName);
            Console.WriteLine("---------------------------------------------");
        }


    }
}
