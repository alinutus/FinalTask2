using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFinalTask
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;

        protected BasePage (IWebDriver driver)
        {
            _driver = driver;
        }

        protected IWebElement GetElementByName(string name)
        {
            int attemptCount = 0;
            while (attemptCount < 5)
            {
                try
                {
                    return _driver.FindElement
                        (
                        By.Name(name)
                        );
                }
                catch
                {
                    Thread.Sleep(5);
                    attemptCount++;
                }
            }

            return null;
        }

        protected IWebElement GetButtonByDataTestid(string dataTestid)
        {
            int attemptCount = 0;
            while (attemptCount < 5)
            {
                try
                {
                    return _driver.FindElement
                        (
                        By.XPath("//button[@data-testid]")
                        );
                }
                catch
                {
                    Thread.Sleep(5);
                    attemptCount++;
                }
            }

            return null;
        }

        protected IWebElement GetDropDownByName(string name)
        {
            int attemptCount = 0;
            while (attemptCount < 5)
            {
                try
                {
                    return _driver.FindElement
                        (
                        By.XPath("//select[@name]")
                        );
                }
                catch
                {
                    Thread.Sleep(5);
                    attemptCount++;
                }
            }

            return null;
        }

        protected IWebElement GetLoginButton(string classText)
        {
            int attemptCount = 0;
            while (attemptCount < 5)
            {
                try
                {
                    return _driver.FindElement
                        (
                        By.XPath("//button[contains(@class,'second-button svelte-1da0ifw hide') and contains(text(),'Войти')]")
                        );
                }
                catch
                {
                    Thread.Sleep(5);
                    attemptCount++;
                }
            }

            return null;
        }

        protected IWebElement GetEmailByClass(string text)
        {
            int attemptCount = 0;
            while (attemptCount < 5)
            {
                try
                {
                    return _driver.FindElement
                        (
                        By.XPath("//div[@class='llc__content']/div/span")
                        );
                }
                catch
                {
                    Thread.Sleep(5);
                    attemptCount++;
                }
            }

            return null;
        }

        protected IWebElement GetAnswerButton(string text)
        {
            int attemptCount = 0;
            while (attemptCount < 5)
            {
                try
                {
                    return _driver.FindElement
                        (
                        By.XPath("//div[@class='letter__footer-button' and @title='Ответить']")
                        );
                }
                catch
                {
                    Thread.Sleep(5);
                    attemptCount++;
                }
            }

            return null;
        }

    }
}