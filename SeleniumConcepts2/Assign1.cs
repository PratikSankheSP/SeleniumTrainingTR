using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts2
{
    public class Assign1
    {
           static void Main3(string[] args)
            {
                ChromeDriver driver = new ChromeDriver();

                driver.Url = "https://www.db4free.net/phpMyAdmin/";
                driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//input[@id='input_username']")).SendKeys("admin");
            driver.FindElement(By.XPath("//input[@name='pma_password']")).SendKeys("admin123");
            driver.FindElement(By.XPath("//input[@value='Log in']")).Click();



            }
        
    }
}
