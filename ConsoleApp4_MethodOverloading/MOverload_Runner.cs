using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_MethodOverloading
{
    public class MOverload_Runner
    {
       static void Main(string[] args)
        {
            MOverloading obj = new MOverloading();

            obj.add(1, 2,10);
            obj.add(1.0, 3);
            obj.add(3,4.0);
            obj.add(25, 25);
        }

           
    }
}
