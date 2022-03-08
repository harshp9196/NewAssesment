using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Assesment
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestMethod]
        public void TestMethod1()
        {

            Navigate navigate = new Navigate(driver);
            navigate.ToPage("CONTACT");

            Contact contact = new Contact(driver);
            contact.EnterForeName();
            contact.EnterEmail();
            contact.EnterMessage();
            contact.ClickSubmit();
         
            // wait to Element display
            new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            Assert.IsTrue("Thanks Dan, we appreciate your feedback" == driver.FindElement(By.ClassName("v-alert__content")).Text);
        }

        public void VerifyVeganPizzaPrice()
        {
            //Navigate to menu 
            Navigate navigate = new Navigate(driver);
            navigate.ToPage("Menu");

            
            PizzaPage page = new PizzaPage(driver);
            page.FindVeganPizza();
            // find the vegen pizza with price 14.99
            page.VerifyPrice(14.99);

        }

            [TestInitialize()]
        public void setup() {
            driver = new ChromeDriver(@"C:\Tools\chromedriver98\chromedriver_win32");
            driver.Url = "https://d2ju5vf8ca0qio.cloudfront.net/#/menu";
            driver.Manage().Window.Maximize();
        }


        [TestCleanup()]
        public void Cleanup() {
           // driver.Quit();
        }


    }

    internal class Navigate
    {
        private IWebDriver driver;

        public Navigate(IWebDriver driver)
        {
            this.driver = driver;
        }

      
        

        internal void ToPage(string page)
        {
            var elements = driver.FindElements(By.ClassName("v-btn__content"));
            new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            foreach (IWebElement item in elements)
            {
                if (item.Text == page)
                {
                    item.Click();
                    break;
                }
            }
        }
    }
}
