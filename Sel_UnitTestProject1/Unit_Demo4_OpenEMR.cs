using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel_UnitTestProject1
{
    class Unit_Demo4_OpenEMR
    {
        [Test]
        public void Oemr()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(30);

            driver.Url = "http://demo.openemr.io/b/openemr/";

            driver.FindElement(By.Id("authUser")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            SelectElement lang = new SelectElement(driver.FindElement(By.XPath("//select[@class='form-control']")));
            lang.SelectByValue("18");

            driver.FindElement(By.Id("login-button")).Click();

            driver.FindElement(By.XPath("//div[contains(text(),'Patient')][1]")).Click();
            driver.FindElement(By.XPath("//div[contains(text(),'New/Search')][1]")).Click();

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='pat']")));

            driver.FindElement(By.XPath("//input[@name='form_fname']")).SendKeys("John");
            driver.FindElement(By.XPath("//input[@name='form_lname']")).SendKeys("Cena");

            driver.FindElement(By.Id("form_DOB")).SendKeys("2024-08-08");

            SelectElement selgen = new SelectElement(driver.FindElement(By.Id("form_sex")));
            selgen.SelectByValue("Male");

            driver.FindElement(By.XPath("//button[@id='create']")).Click();





        }
    }
}
