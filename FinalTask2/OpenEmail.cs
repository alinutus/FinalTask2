using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFinalTask
{
    public class OpenEmail:BasePage
    {
        const string ANSWER_BUTTON_CLASS = "";


        IWebElement _answerButton;

        public OpenEmail(IWebDriver driver) : base(driver)
        {
            _answerButton = GetAnswerButton(ANSWER_BUTTON_CLASS);
        }

        public OpenEmail EmailAnswerButton(string text)
        {
            _answerButton?.Click();

            Thread.Sleep(1000);

            return new OpenEmail(_driver);
        }
    }
}
