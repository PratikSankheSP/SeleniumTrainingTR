using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;

namespace Sel_UnitTestProject1
{
    public class UnitDemo5_SelAdvance
    {
        [Test]
        public void ValidUploadTest()
        {
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.ilovepdf.com/pdf_to_word";

            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"C:\Users\6124596\OneDrive - Thomson Reuters Incorporated\iSquad\Selenium Training\brief_note_on_tax_regime.pdf");


        }

        [Test]
        public void Demo2ActionsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.myntra.com/";


            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Men']"))).Perform();

            //mouse over on FutureSkills
            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='FutureSkills Prime']"))).Perform();

            driver.FindElement(By.XPath("//a[text()='About Us']")).Click();

        }

        [Test]
        public void Demo3ActionsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://futureskillsprime.in/";


            Actions actions=new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//span[text()='Explore']"))).Perform();

            //mouse over on FutureSkills
            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='FutureSkills Prime']"))).Perform();

            driver.FindElement(By.XPath("//a[text()='About Us']")).Click();

        }

        [Test]

        public void Demo5JScript()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized"); // chrome options allow to maximized browser from beginning
            options.AddArguments("--disable-notifications"); // chrome options allow to disable notification in browser

            IWebDriver driver = new ChromeDriver(options);
            //driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.malaysiaairlines.com/us/en/home.html";

            driver.FindElement(By.XPath("//span[text()='Accept all cookies']")).Click();

            //approach 1 - not working
            //driver.FindElement(By.XPath("//input[@name='dateDeparture']")).SendKeys("01 Oct 2024");

            //approach 2 - automate the date calendar

            //approach 3- javascript
            driver.ExecuteJavaScript("document.querySelector(\"input[name='dateDeparture']\").value='01 Oct 2024'");

            driver.ExecuteJavaScript("document.querySelector(\"input[name='dateReturn']\").value='11 Oct 2024'");

        }

       
    }
}
