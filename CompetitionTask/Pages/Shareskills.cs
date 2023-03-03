using CompetitionTask.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionTask.Pages
{
    public class Shareskills
    {
        public void Gotomanagelisting(IWebDriver driver)
        {
            //Click share skills and add details

           
            IWebElement Shareskills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));
            Shareskills.Click();

            IWebElement Title = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            Title.SendKeys("Communication");

            IWebElement Description = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            Description.SendKeys("Communication is an important skills that you need to succeed in work place");

            IWebElement Category = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select"));
            Category.Click();

            IWebElement Selectcategory = driver.FindElement(By.XPath("//option[@value='6']"));
            Selectcategory.Click();

            IWebElement SelectSubcategory = driver.FindElement(By.Name("subcategoryId"));
            SelectSubcategory.Click();

            IWebElement QAselect = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]"));
            QAselect.Click();

            IWebElement SelectTag = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input"));
            SelectTag.SendKeys("java");
            SelectTag.SendKeys(Keys.Enter);

            IWebElement ServiceType = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
            ServiceType.Click();

            IWebElement LocationType = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            LocationType.Click();

            IWebElement Availabledays = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            Availabledays.Click();

            IWebElement Selectdays = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input"));
            Selectdays.Click();

            IWebElement Selectdays1 = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
            Selectdays1.Click();

            IWebElement Selectdays2 = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input"));
            Selectdays2.Click();

            IWebElement SkillCredit = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
            SkillCredit.Click();

            IWebElement Creditvalue = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/input"));
            Creditvalue.SendKeys("5");

            IWebElement ActiveBotton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
            ActiveBotton.Click();

            IWebElement SaveBotton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
            SaveBotton.Click();
           
            Wait.WaitforElementTobeclickable(driver, "Xpath", "//*[@id=\"listing-management-section\"]/section[1]/div/a[3]", 5);

        }
    }
}
