using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace VVS_projekat
{
    public class Tests: BasePage
    {
        private HomePage homePage;
        private LogInPage logInPage;
        private ReviewPage reviewPage;
        private ProductPage productPage;

        [SetUp]
        public void Setup()
        {
           InitializeWebDrive();
           homePage = new HomePage(GetDriver());
           logInPage = new LogInPage(GetDriver());
           reviewPage = new ReviewPage(GetDriver());
           productPage = new ProductPage(GetDriver()); 
        }

       
        [Test, Order(1)]
        public void TestDodavanjeReview()
        {
            homePage.openReviewForm();

            Assert.AreEqual("Only registered users can write reviews", reviewPage.getLableMessage());

            logInPage.LogInUser("test@mail.com", "test123");
            reviewPage.SendReview("Test review", "Test review text");

            Assert.AreEqual("Test review", reviewPage.getReviewTitle());
            Assert.AreEqual("Test review text", reviewPage.getReviewText());
            Assert.IsTrue(reviewPage.getRating());
        }

        
        [Test, Order(2)]
        public void TestDodavanjeProizvodaUListuSaOgranicenomKolicinom()
        {
            homePage.openProductDetails();
            Assert.AreEqual("This product has a minimum quantity of 2", productPage.GetQuantityLabel());

            productPage.OrderProduct("10");
            Assert.AreEqual("Invalid order", productPage.GetMessage());
        }


        [OneTimeTearDown]
        public void TearDown()
        {
           Close();
        }
 
    }
}