using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompetitionTask.Utilities;
using NUnit.Framework.Internal;
using Microsoft.Diagnostics.Runtime.DacInterface;

namespace CompetitionTask.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
           
            driver.Manage().Window.Maximize();

            // launch localhost
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            //Chick on Signin Botton
            IWebElement SigninBotton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            SigninBotton.Click();


            //Identify username textbox and enter valid username
            IWebElement UserNameTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            UserNameTextBox.SendKeys("anjalyalwin123@gmail.com");

            //Identify password textbox and enter valid Password
            IWebElement PasswordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            PasswordTextBox.SendKeys("Abraham123");

            // click on login botton
            IWebElement LoginBotton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            LoginBotton.Click();
            Wait.WaitforElementTobeclickable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 5);

            //check if user has logged in successfully
            IWebElement HiAnjaly = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));

            if (HiAnjaly.Text == "Hi Anjaly")
            {
               Console.WriteLine("Logged in successfully, test passed");
               
            }
            else
            {
                Console.WriteLine("Login failed , test failed");
            }
            
        
        }
    }
}
