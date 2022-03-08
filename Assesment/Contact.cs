using System;
using OpenQA.Selenium;

namespace Assesment
{
    internal class Contact
    {
        private IWebDriver driver;
        public string ForeName => driver.FindElement(By.Id("forename")).Text;
        public string Email => driver.FindElement(By.Id("email")).Text;
        public string Message => driver.FindElement(By.Id("message")).Text;

        public Contact(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void EnterForeName()
        {
        //   if(!driver.FindElement(By.Id("")).Displayed) 
            driver.FindElement(By.Id("forename")).SendKeys("Dan");
        }

        internal void ClickSubmit()
        {


            var Allbutn =driver.FindElements(By.ClassName("v-btn__content"));
            foreach (var item in Allbutn)
            {
                if (item.Text.ToUpper() == "SUBMIT") {
                    item.Click();
                }
            }
        }

        internal void EnterEmail()
        {
            driver.FindElement(By.Id("email")).SendKeys("dan@abc.com");
        }

        internal void EnterMessage()
        {
            driver.FindElement(By.Id("message")).SendKeys("Nice pizza");
        }
    }
}