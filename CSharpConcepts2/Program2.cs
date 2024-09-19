using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thomsonreuters.formulae;

namespace CSharpConcepts2
{
    public class Program2
    {
        //access specifier static or non static return type method name (Paramneters)

       
        static void Main(string[] args)
        {  // Creating object of class to call non static varibales, methods, properties present in class
            // Class name object name= new(institation) Class name() (Constructor))
            Area obj=new Area();


            Console.WriteLine("Please enter radius of first Circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Area.AreaOfCircle(radius); // call without class Name if method exist within same class
            System.Console.WriteLine("Area of 1st Circle:" + area);

            Console.WriteLine("Please enter radius of Second Circle:");
            double radius2 = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Area of 2nd Circle:" + Area.AreaOfCircle(radius2)); // call static method with class name

            Console.WriteLine("Enter length of Rectangle:");
            double ln=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width of Rectangle:");
            double wd = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area of Rectangle: " + obj.AreaofRectangle(ln, wd));

            Console.WriteLine("Enter base of Traingle:");
            double bs = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height of Triangle:");
            double hg= Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Area of Traingle: "+obj.AreaOfTriangle(bs, hg));

            Console.WriteLine("Name: " + Area.MyName());

            obj.Quit();
        }
    }
}
