using System;
using OpenQA.Selenium;

namespace Industryconnect.Pages
{
    public class HomePage
    {
        public void navigateToTM(IWebDriver driver)
        {

            //check the homepage is displayed
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            if (hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, Test passed");
            }
            else
            {
                Console.WriteLine("Login page not seen, Test failed");
            }

        }
    }
}
