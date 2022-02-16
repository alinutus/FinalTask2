using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumFinalTask
{
    class SendMail
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://mail.ru";

            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterLogin("asievna");
            loginPage.EnterPassword("martin2017");

            Thread.Sleep(1000);

            EmailPage emailPage = new EmailPage(driver);
            emailPage.EmailAnswer("");

            OpenEmail openEmail = new OpenEmail(driver);
            openEmail.EmailAnswerButton("");

        }
    }
}