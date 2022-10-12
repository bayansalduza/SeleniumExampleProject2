using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumExampleProject
{
    public class WebDriverExtensions
    {
        private IWebDriver webDriver;
        public WebDriverExtensions(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void SendIdKeys(string Id, string Keys)
        {
            webDriver.FindElement(By.Id(Id)).Clear();
            webDriver.FindElement(By.Id(Id)).SendKeys(Keys);
        }

        public void SendClassClick(string clicClassName)
        {
            webDriver.FindElement(By.CssSelector(clicClassName)).Click();
        }
    }
}
