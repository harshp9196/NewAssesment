using System;
using OpenQA.Selenium;

namespace Assesment
{
    internal class PizzaPage
    {
        private IWebDriver driver;

        public PizzaPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void FindVeganPizza()
        {
           var pizza=  driver.FindElements(By.ClassName("flex-card"));
            foreach (var iteam in pizza)
            {
                if (iteam.FindElement(By.TagName("span")).Text == "v") { 
                // create list of vegen pizza and set price
                }
            }

        }

        internal void VerifyPrice(double v)
        {
            throw new NotImplementedException();
        }
    }
}