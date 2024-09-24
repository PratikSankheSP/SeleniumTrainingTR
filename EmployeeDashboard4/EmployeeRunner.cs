using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard4
{
    public class EmployeeRunner
    {
        static void Main(string[] args)
        {
            Employee.companyName = "TR";

            Employee emp1= new Employee();
            Employee emp2= new Employee();
            Employee emp3= new Employee();


            emp1.EmployeeID = 101; // set value for property
            emp1.empName = "Saul";
            emp1.empSalary = 9000;
            emp1.EmployeePerformance = "B"; // set value for property

            emp2.EmployeeID = 102; // set value for property
            emp2.empName = "Peter";
            emp2.empSalary =7000 ;
            emp2.EmployeeSalary = 12000;
            emp2.EmployeePerformance = "A";// set value for property

            Console.WriteLine(emp1.EmployeeID);
            

            emp1.PrintEmployeeDetails();
            emp1.Allocatebonus();
            Console.WriteLine(emp1.EmployeeSalary);
            emp1.PrintEmployeeDetails();

            emp2.PrintEmployeeDetails();
            emp2.Allocatebonus();
            emp2.PrintEmployeeDetails();

            emp3.PrintEmployeeDetails();
            emp3.Allocatebonus();
            emp3.PrintEmployeeDetails();

            Employee.ObjCreation();
            Employee.PrintEmpDetails(emp1);


            Console.WriteLine(emp1.EmployeeID);    // get value from property
            Console.WriteLine(emp2.EmployeePerformance); // get value for property


        }
    }
}
