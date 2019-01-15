using System;
using System.Threading;
using Industryconnect.Helpers;
using Industryconnect.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Industryconnect.Test
{ 
    [TestFixture]
    class Program
        {
            [SetUp]
            public void loginNavigate()
                {
                    CommonDriver.driver = new ChromeDriver(@"/Users/oiyo/Projects/Industryconnect/Industryconnect/");

                    LoginPage LoginObject = new LoginPage();
                    LoginObject.loginSteps(CommonDriver.driver);

                    HomePage HomeObject = new HomePage();
                    HomeObject.navigateToTM(CommonDriver.driver);

                }
            [Test]      
            public void addTMTest()
                {

                    TimeMaterialPage TMObject = new TimeMaterialPage();
                    TMObject.addTM(CommonDriver.driver);
                }
            [Test]
            public void editTMTest()
                {
                    TimeMaterialPage TMObject = new TimeMaterialPage();
                    TMObject.editTM(CommonDriver.driver);

                }
            [Test]
            public void deleteTMTest()
                {
                    TimeMaterialPage TMObject = new TimeMaterialPage();
                    TMObject.deleteTM(CommonDriver.driver);
                }
            [TearDown]
            public void CloseBrowser()
                {
                    CommonDriver.driver.Close();
                }

        }
}
             


