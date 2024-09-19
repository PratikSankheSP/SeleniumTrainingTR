using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_MethodOverloading
{
    public class MOverloading
    {
        public void add(int a,int b)
        {
            Console.WriteLine(a + b);

        }
        public void add(int a, int b, double c)
        {
            Console.WriteLine(a+b+c);

        }
        public void add(double a, int b)
        {
            Console.WriteLine(a + b);

        }
        public void add(int a, double b)
        {
            Console.WriteLine(a + b);

        }
    }
}
