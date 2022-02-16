using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFinalTask
{
    public class LoginPage : BasePage
    {
        const string LOGIN_TEXT_FIELD_NAME = "login";
        const string ENTER_PASSWORD_BUTTON_DATA_TESTID = "enter-password";
        const string DROP_DOWN_SELECTION_NAME = "domain";
        const string PASSWORD_TEXT_FIELD_NAME = "password";
        const string LOGIN_BUTTON_CLASS = "";

        IWebElement _loginTextFieldName;
        IWebElement _enterPasswordButton;
        IWebElement _drop_down_selection;
        IWebElement _passwordTextFieldName;
        IWebElement _loginButton;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            _loginTextFieldName = GetElementByName(LOGIN_TEXT_FIELD_NAME);
            _enterPasswordButton = GetButtonByDataTestid(ENTER_PASSWORD_BUTTON_DATA_TESTID);
            _drop_down_selection = GetDropDownByName(DROP_DOWN_SELECTION_NAME);
            _passwordTextFieldName = GetElementByName(PASSWORD_TEXT_FIELD_NAME);
            _loginButton = GetLoginButton(LOGIN_BUTTON_CLASS);
        }

        public LoginPage EnterLogin (string informationToEnter)
        {
            _loginTextFieldName?.SendKeys(informationToEnter);
            _drop_down_selection?.Click();
            _drop_down_selection?.SendKeys("@internet.ru");
            _enterPasswordButton?.Click();

            Thread.Sleep(1000);

            return new LoginPage(_driver);
        }

        public LoginPage EnterPassword(string informationToEnter)
        {
            _passwordTextFieldName?.SendKeys(informationToEnter);
            _loginButton?.Click();

            Thread.Sleep(1000);

            return new LoginPage(_driver);
        }
    }
}
