using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVS_projekat
{
    public class HomePage
    {
        private string test_url = "https://demo.nopcommerce.com/";
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[2]/ul[1]/li[1]/a")]
        private IWebElement Computers;
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div[2]/div[1]/div[2]/ul/li[1]/ul/li[2]/a")]
        private IWebElement Notebooks;
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div[3]/div/div[2]/div[2]/div[2]/div/div/div[1]/div/div[1]/a/img")]
        private IWebElement Product;
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div[2]/div/div/form/div[2]/div[1]/div[2]/div[3]/div[2]/a[2]")]
        private IWebElement ReviewLink;
        
        public void openReviewForm()
        {
            Thread.Sleep(1000);
            Computers.Click();
            Thread.Sleep(1000);
            Notebooks.Click();
            Thread.Sleep(1000);
            Product.Click();
            Thread.Sleep(1000);
            ReviewLink.Click();
            Thread.Sleep(1000);
        }

        public void openProductDetails()
        {
            Thread.Sleep(1000);
            Computers.Click();
            Thread.Sleep(1000);
            Notebooks.Click();
            Thread.Sleep(1000);
            Product.Click();
            Thread.Sleep(1000);
        }

    }
}
