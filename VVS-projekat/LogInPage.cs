using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVS_projekat
{
    public class LogInPage
    {
        private String test_url = "https://demo.nopcommerce.com/";
        private IWebDriver driver;

        public LogInPage(IWebDriver driver) 
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div/div/div[2]/div[1]/div[2]/form/div[2]/div[1]/input")]
        private IWebElement MailInput;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div/div/div[2]/div[1]/div[2]/form/div[2]/div[2]/input")]
        private IWebElement PasswordInput;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div/div/div[2]/div[1]/div[2]/form/div[3]/button")]
        private IWebElement LogInButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a")]
        private IWebElement LogIn;


        public void LogInUser(string username, string password)
        {
            LogIn.Click();
            Thread.Sleep(1000);
            MailInput.SendKeys(username);
            Thread.Sleep(1000);
            PasswordInput.SendKeys(password);
            Thread.Sleep(1000);
            LogInButton.Click();
            Thread.Sleep(1000);
        }


    }
}
