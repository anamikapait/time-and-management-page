using System;
using System.Threading;
using OpenQA.Selenium;

namespace Industryconnect.Pages
{
    public class TimeMaterialPage
    {
        public void addTM(IWebDriver driver)
        {
            //Navigate to Time and Material page
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();

            //Click on Time and management
            IWebElement timeAndManagement = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]"));
            timeAndManagement.Click();

            //Create a new time and material 
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNew.Click();

            //select time in typecode
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div"));
            typeCode.Click();
            IWebElement time = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            time.Click();
            IWebElement timeoption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeoption.Click();

            //enter code
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("oiyo1");

            //enter description
            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("ilovemyself");

            //enter price per unit
            IWebElement pricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnit.SendKeys("2");

            //Click on save button
            IWebElement save = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            save.Click();

            //Check if the time and management is created sucessfully
            Thread.Sleep(1000);
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@title=\"Go to the last page\"]"));
            lastPage.Click();
            IWebElement codeToCheck = driver.FindElement(By.XPath("//td[text()='oiyo1']"));
            if (codeToCheck.Text == "oiyo1")
            {
                Console.WriteLine("Time and Management created successfully");

            }
            else
            {
                Console.WriteLine("Test Failed");
            }

        }

        internal void deleteTM(IWebDriver driver)
        {
            //Navigate to Time and Material page
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();

            //Click on Time and management
            IWebElement timeAndManagement = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]"));
            timeAndManagement.Click();

            //Delete the Time and material first row in the last page
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@title=\"Go to the last page\"]"));

            lastPageButton.Click();
            Thread.Sleep(1000);
            IWebElement delete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[1]/td[5]/a[2]"));
            delete.Click();
            driver.SwitchTo().Alert().Accept();
        }

        internal void editTM(IWebDriver driver)
        {
            //Navigate to Time and Material page
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();

            //Click on Time and management
            IWebElement timeAndManagement = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]"));
            timeAndManagement.Click();
            Thread.Sleep(1000);

            //edit the first row of Time and Material
            IWebElement edit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[1]/td[5]/a[1]"));
            edit.Click();

            //change the description of oiyo1
            IWebElement Description = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            Description.Click();
            IWebElement clearDescription = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            clearDescription.Clear();
            IWebElement changeDescripton = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            changeDescripton.SendKeys("happyoiyo");

            //Click on save button
            IWebElement save1 = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            save1.Click();

        }
    }
}
