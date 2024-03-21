using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QA_Assessment.Elements
{
    internal class Cart
    {
        IWebDriver WebDriver { get; }

        public Cart(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement TshirtDescription => WebDriver.FindElement(By.ClassName("inventory_item_desc"));

        public IWebElement TshirtName => WebDriver.FindElement(By.ClassName("inventory_item_name"));

        public IWebElement TshirtPrice => WebDriver.FindElement(By.ClassName("inventory_item_price"));

        public IWebElement cartPage => WebDriver.FindElement(By.Id("cart_contents_container"));

        public IWebElement Checkout => WebDriver.FindElement(By.Id("checkout"));

        public string SelectedTshirtPrice()
        {
            string selectedtshritprice = TshirtPrice.Text;

            return selectedtshritprice;

        }
        public string SelectedTshirtDescription()
        {
            string selectedtshritdescription = TshirtDescription.Text;

            return selectedtshritdescription;

        }

        public string SelectedTshirtName()
        {
            string selectedtshritname = TshirtName.Text;

            return selectedtshritname;

        }
    }
}
