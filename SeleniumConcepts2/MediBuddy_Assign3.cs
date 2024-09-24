using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts2
{
    public class MediBuddy_Assign3
    {
        static void Main(string[] args)
        {
            IWebDriver driver=new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            driver.Url = "https://www.medibuddy.in/";

            driver.FindElement(By.XPath("//a[contains(text(),'Login')]")).Click();

            driver.FindElement(By.XPath("//div[contains(text(),'Corporate Account')]")).Click();

            driver.FindElement(By.XPath("//input[@id='corpphone']")).SendKeys("1234567890");

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            driver.Quit();

           // string actualError=driver.FindElement(By.XPath())








        }
    }
}
