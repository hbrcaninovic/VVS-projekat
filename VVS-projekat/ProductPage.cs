using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVS_projekat
{
    public class ProductPage
    {
        private string test_url = "https://demo.nopcommerce.com/";
        private IWebDriver driver;
       
        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div[2]/div/div/form/div[2]/div[1]/div[2]/div[8]/div[1]")]
        private IWebElement QuantityLabel;

        [FindsBy(How = How.XPath, Using = "html/body/div[6]/div[3]/div/div[2]/div/div/form/div[2]/div[1]/div[2]/div[8]/div[2]/input")]
        private IWebElement QuantityInputField;

        [FindsBy(How = How.XPath, Using = "html/body/div[6]/div[3]/div/div[2]/div/div/form/div[2]/div[1]/div[2]/div[8]/div[2]/button")]
        private IWebElement AddToChartButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/p")]
        private IWebElement Message;


        public string GetQuantityLabel()
        {
            return QuantityLabel.Text;
        }

        public void OrderProduct(string quantity) 
        {
            QuantityInputField.SendKeys(quantity);
            AddToChartButton.Click();
        }

        public string GetMessage()
        {
            return Message.Text;
        }

    }
}
