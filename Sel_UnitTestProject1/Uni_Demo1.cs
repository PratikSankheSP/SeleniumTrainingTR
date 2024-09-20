using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel_UnitTestProject1
{
    
    public class Uni_Demo1
    {

        [Test]
        public void Demo1MultipleTabsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/";

            //driver.FindElement(By.LinkText("phpMyAdmin »")).Click();

            driver.FindElement(By.XPath("//b[contains(text(),'phpMyAdmin')]")).Click();

            //switch to second tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Name("pma_username")).SendKeys("Admin");
            driver.FindElement(By.Id("input_password")).SendKeys("Abcd@123");
            driver.FindElement(By.Id("input_go")).Click();

            string actualError = driver.FindElement(By.XPath("//div[contains(text(),'Access denied for')]")).Text;
            Console.WriteLine("Error Message is " + actualError);

            driver.Close(); // closes cureent session ot tab
            //Quit kills all session and close browser and kill process running 

            driver.SwitchTo().Window(driver.WindowHandles[0]);

            string title = driver.Title;
            Console.WriteLine("Actual Title:" + title);

            driver.Quit();
        }

        [Test]

        public void Demo2MultipleTabsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.online.citibank.co.in/";

            //close all popup
            //driver.FindElement(By.ClassName("newclose")).Click();
            driver.FindElement(By.XPath("//a[@class='newclose']")).Click();

            //driver.FindElement(By.ClassName("newclose2")).Click();
            driver.FindElement(By.XPath("//a[@class='newclose2']")).Click();

            //click on Banking
            driver.FindElement(By.LinkText("Banking")).Click();

            //click on Citi Commercial Bank
            driver.FindElement(By.LinkText("Citi Commercial Bank")).Click();

            //click on Branch/ATM
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//a[contains(text(),'Branch/ATM')]")).Click();


            //Select Citibank ATM as Bengaluru 
            driver.FindElement(By.XPath("(//a[text()='Choose One'])[1]")).Click();
            driver.FindElement(By.XPath("(//a[text()='Bengaluru'])[1]")).Click();

            driver.Quit();
        }
    }
}
