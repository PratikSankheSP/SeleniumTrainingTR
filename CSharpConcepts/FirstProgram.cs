using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.CSharpConcepts.Spbinder
{
    public class FirstProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning");
            Console.WriteLine("Welcome to C# Training");

            sbyte var1 = 120;
            byte var2 = 200;
            short var3 = 500;
            int var4 = 2456;

            long l = 3464363463;
            float f = 6.7f;
            double d = 2353.243245;

            char c = '%';
            bool B = false;

            Console.WriteLine("Boolean Value is "+B);

            string[] colors = new string[] { "red", "green", "yellow" };
            Console.WriteLine(colors[0]);





        }
    }
}
