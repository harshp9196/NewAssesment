using System;
using OpenQA.Selenium;

namespace Assesment
{
    internal class Pizza
    {
        private IWebDriver driver;

        string Name => driver.FindElement(By.ClassName("Name")).Text;

        double price => Double.Parse(driver.FindElement(By.ClassName("price")).Text);

        public Pizza(IWebDriver driver)
        {
            this.driver = driver;
        }

       
    }
}