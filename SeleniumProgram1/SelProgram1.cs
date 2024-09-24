using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
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
            IWebDriver obj;
            Console.WriteLine("Enter Browser Name: edge or chrome");
             string browser = Console.ReadLine();

            //IWebDriver obj1 = new ChromeDriver();

            if(browser.Equals("edge"))
            {
                obj=new EdgeDriver();
            }
            else if(browser.Equals("chrome"))
            {
                obj = new ChromeDriver();  
            }
            else
            {
                obj=new FirefoxDriver();
            }

           // FirefoxDriver obj1 = new FirefoxDriver();

            obj.Url = "https://www.google.com/";

            Console.WriteLine(obj.Url);
            string actualTitle = obj.Title;
            Console.WriteLine("Title is: " + actualTitle);

            obj.Quit();

            //obj1.Url = "https://www.facebook.com";
            //Console.WriteLine(obj1.Url);
            //Console.WriteLine(obj1.Title);


            //obj1.Quit();


        }
    }
}
