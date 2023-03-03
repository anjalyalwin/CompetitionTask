using CompetitionTask.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionTask.Pages
{
    public class ManageListing
    {
        public void Edit(IWebDriver driver)
        {
            //Go to manage listing page and click on edit botton

            IWebElement ManageList = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/section[1]/div/a[3]"));
            ManageList.Click();
           
            Wait.WaitforElementTobeclickable(driver, "Xpath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]/i", 5);

            IWebElement Editbotton = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]/i"));
            Editbotton.Click();
            
            Wait.WaitforElementTobeclickable(driver, "Xpath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input", 5);

            IWebElement Edit = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            Edit.SendKeys("Management");

            IWebElement Save = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
            Save.Click();
           
            Wait.WaitforElementTobeclickable(driver, "Xpath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i", 5);

        }
        public void Delete(IWebDriver driver) 
        {
            IWebElement deletebotton = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i"));
            deletebotton.Click();
          
            Wait.WaitforElementTobeclickable(driver, "Xpath", "/html/body/div[2]/div/div[3]/button[2]", 5);
            IWebElement deleteyes = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
            deleteyes.Click();
          

        }

    }
}
