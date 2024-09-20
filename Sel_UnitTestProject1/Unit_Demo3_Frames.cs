using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel_UnitTestProject1
{
    
    public class Unit_Demo3_Frames
    {
        [Test]
        public void HdfcFrameTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            //Switch to frame using IwebElement
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            //enter userid as john123
            driver.FindElement(By.XPath("//input[contains(@class,'form-control')]")).SendKeys("john123");
            driver.FindElement(By.LinkText("CONTINUE")).Click();

            //switch to main html
            driver.SwitchTo().DefaultContent();

        }

    }
}
