using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFinalTask
{
    public class EmailPage: BasePage
    {
        const string EMAIL_CLASS = "";


        IWebElement _clickEmail;

        public EmailPage(IWebDriver driver) : base(driver)
        {
            _clickEmail = GetEmailByClass(EMAIL_CLASS);
        }

        public EmailPage EmailAnswer(string text)
        {
            _clickEmail?.Click();

            Thread.Sleep(1000);

            return new EmailPage(_driver);
        }
    }
}
