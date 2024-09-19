using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.CSharpConcepts.Spbinder
{
    public class Program3
    {
        public static int sv1 = 10; // static variable or class variable
        public static int sv2 = 20;

        public int nsv1 = 100; // Non Static Variable or Instance Variable
        public int nsv2 = 200;
        static void Main(string[] args)
        {
            Program3.sv1 = 1000;

            Console.WriteLine(Program3.sv1);
            Console.WriteLine(Program3.sv2);

            Program3 obj1 = new Program3();

            Console.WriteLine(obj1.nsv1 + " " + obj1.nsv2);





        }
    }
}
