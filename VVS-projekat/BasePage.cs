using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVS_projekat
{
    public class BasePage
    {
        private String test_url = "https://demo.nopcommerce.com/";
        private IWebDriver driver;

        public void InitializeWebDrive() 
        {
            driver = SingletonWebDriver.Instance;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(test_url);
        }

        public IWebDriver GetDriver() { return driver; }

        public void Close() 
        {
            driver.Quit();
        }

    }
}
