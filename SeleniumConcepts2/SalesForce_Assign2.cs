using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts2
{
    public class SalesForce_Assign2
    {
        static void Main(string[] args)
        {
            IWebDriver driver=new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            
            //driver.FindElement(By.Name("UserLastName")).SendKeys("Wick");
            driver.FindElement(By.XPath("//input[@name='UserLastName']")).SendKeys("Wick");

            driver.FindElement(By.Name("UserEmail")).SendKeys("john.wick@gmail.com");

            SelectElement selectrole = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectrole.SelectByValue("IT_Manager_AP");

            driver.FindElement(By.XPath("(//div[@class='checkbox-ui'])[2]")).Click();

            SelectElement selectnoofemp = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectnoofemp.SelectByValue("150");

            SelectElement selcountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selcountry.SelectByValue("GB");

            //Start my Free trial Click
            driver.FindElement(By.Name("start my free trial")).Click() ;

            //Get header and print
            string actualheader = driver.FindElement(By.Id("no-credit-card-required-no-software-to-install")).Text;
            Console.WriteLine(actualheader);

            //Get Error Message and print

            string actualerror = driver.FindElement(By.XPath("//span[contains(text(),'valid phone number')]")).Text;
            Console.WriteLine(actualerror);






        }
    }
}
