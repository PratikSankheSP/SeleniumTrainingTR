using Docker.DotNet.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts2
{
    public class FbLogin

    {
        static void Main2(string[] args)
        {


            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";

            driver.FindElement(By.Id("email")).SendKeys("abc@gmail.com");
            driver.FindElement(By.Name("pass")).SendKeys("Password");
            driver.FindElement(By.Name("login")).Click();  // cLICK ON lOGIN bUTTON




        }


        

       
    }
}
