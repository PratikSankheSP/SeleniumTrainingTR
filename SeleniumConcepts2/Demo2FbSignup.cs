using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts2
{
    public class Demo2FbSignup
    {
        static void Main2(string[] args)
        {
            IWebDriver driver=new ChromeDriver();

            driver.Url = "https://www.facebook.com";

            driver.Manage().Window.Maximize();
            //Thread.Sleep(20); Not Recommended as 20 secs wait is manadatory even if operation is completed.
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);

            driver.FindElement(By.LinkText("Create new account")).Click();
            //Enter firstname as John
            driver.FindElement(By.Name("firstname")).SendKeys("John");

            //Enter Lastname as Wick
            driver.FindElement(By.Name("lastname")).SendKeys("wick");
            //Enter Email as john@gmail.com
            driver.FindElement(By.Name("reg_email__")).SendKeys("john@gmail.com");
            //Enter Password 
            driver.FindElement(By.Id("password_step_input")).SendKeys("Passabc");

            //Enter date of birth  17 sep 1990

            SelectElement selday = new SelectElement(driver.FindElement(By.Id("day")));
            selday.SelectByText("17");

            SelectElement selmonth = new SelectElement(driver.FindElement(By.Id("month")));
            selmonth.SelectByIndex(6);

            SelectElement selyear = new SelectElement(driver.FindElement(By.XPath("//select[@id='year']")));
            selyear.SelectByText("1990");

            //Select Gender as Male
            driver.FindElement(By.XPath("//input[@value='2']")).Click();

            //Click on SignUp Button
            driver.FindElement(By.XPath("//button[@name='websubmit']")).Click();

        }
    }
}
