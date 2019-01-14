using System;
using System.Threading;
using Industryconnect.Helpers;
using Industryconnect.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Industryconnect
{
    class Program
    {

        static void Main(string[] args)
        {

            CommonDriver.driver = new ChromeDriver(@"/Users/oiyo/Projects/Industryconnect/Industryconnect/");

            LoginPage LoginObject = new LoginPage();
            LoginObject.loginSteps(CommonDriver.driver);

            HomePage HomeObject = new HomePage();
            HomeObject.navigateToTM(CommonDriver.driver);

            TimeMaterialPage TMObject = new TimeMaterialPage();
            TMObject.addTM(CommonDriver.driver);
        }
    }
}
             


