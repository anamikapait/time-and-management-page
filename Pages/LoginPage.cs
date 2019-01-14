using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Industryconnect.Pages
{
    public class LoginPage
    {
        public void loginSteps(IWebDriver driver)
        {
            //Enter the url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //Enter the username 
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            //Enter the password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            //click the login button
            IWebElement login = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            login.Submit();
        }
    }
}
