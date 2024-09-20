using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel_UnitTestProject1
{
    public class Unit_Demo2Test
    {
        [Test]
        public void AlertTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";


            //to inspect--> f12 or ctrl+shift+c

            //click on Go
            //driver.FindElement(By.XPath("//img[@alt='Go']")).Click();
            driver.FindElement(By.XPath("//img[contains(@src,'go.gif')]")).Click();

            String actualAlertText = driver.SwitchTo().Alert().Text;
            Console.WriteLine(actualAlertText);

            driver.SwitchTo().Alert().Accept();


        }
    }
}
