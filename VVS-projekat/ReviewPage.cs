using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVS_projekat
{
    public class ReviewPage
    {
        private string test_url = "https://demo.nopcommerce.com/";
        private IWebDriver driver;
        public ReviewPage(IWebDriver driver) 
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div/div/div[2]/div[1]/form/div[1]/div/div[1]/input")]
        private IWebElement ReviewTitleInput;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div/div/div[2]/div[1]/form/div[1]/div/div[2]/textarea")]
        private IWebElement ReviewTextInput;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div/div/div[2]/div[1]/form/div[1]/div/div[3]/div[2]/div[2]/input[6]")]
        private IWebElement RatingValue;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div/div/div[2]/div[1]/form/div[2]/button")]
        private IWebElement SubmitReviewButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div/div/div[2]/div[1]/form/div[1]/ul/li")]
        private IWebElement LableMessage;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div/div/div[2]/div[2]/div[2]/div[1]/div[1]/strong")]
        private IWebElement ReviewTitle;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div/div/div[2]/div[2]/div[2]/div[2]/div[1]/div")]
        private IWebElement ReviewText;

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div/div/div[2]/div[2]/div[2]/div[1]/div[2]/div")]
        private IWebElement Rating;

        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement ConfirmationMessageLabel;

        public string getLableMessage()
        {
            return LableMessage.Text;
        }
        public string getReviewTitle()
        {
            return ReviewTitle.Text;
        }
        public string getReviewText()
        {
            return ReviewText.Text;
        }
        public bool getRating()
        {
            return Rating.Displayed;
        }

        public void SendReview(string title, string text)
        {
            ReviewTitleInput.SendKeys(title);
            Thread.Sleep(1000);
            ReviewTextInput.SendKeys(text);
            Thread.Sleep(1000);
            RatingValue.Click();
            Thread.Sleep(1000);
            SubmitReviewButton.Click();
            Thread.Sleep(1000);

        }
    }
}
