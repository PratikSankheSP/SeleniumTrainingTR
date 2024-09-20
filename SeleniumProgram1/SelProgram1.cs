using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProgram1
{
    public class SelProgram1
    {
        static void Main(string[] args)
        {
             IWebDriver obj = new ChromeDriver();
            //IWebDriver obj1 = new ChromeDriver();

            if(obj.Equals(new ChromeDriver()))
            {

            }

            FirefoxDriver obj1 = new FirefoxDriver();

            obj.Url = "https://www.google.com/";

            Console.WriteLine(obj.Url);
            string actualTitle = obj.Title;
            Console.WriteLine("Title is: " + actualTitle);

            obj1.Url = "https://www.facebook.com";
            Console.WriteLine(obj1.Url);
            //Console.WriteLine(obj1.Title);

            obj.Quit();
            //obj1.Quit();


        }
    }
}
