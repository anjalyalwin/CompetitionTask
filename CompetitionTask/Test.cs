using CompetitionTask.Pages;
//using CompetitionTask.Reports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionTask
{

    [TestFixture]
    public class Tests
    {

        [SetUp]

        public void login()
        {


            IWebDriver driver = new ChromeDriver();
            // login page object Intialization and defintion
            LoginPage loginpageObj = new LoginPage();
            loginpageObj.LoginActions(driver);


            //shareskills object intialization and defintion
            Shareskills ShareskillsObj = new Shareskills();
            ShareskillsObj.Gotomanagelisting(driver);

        }

        [Test]
        public void edit1()
        {

            IWebDriver driver = new ChromeDriver();
            //managelisting object Intialization and defition
            ManageListing MangageListingObj = new ManageListing();
            MangageListingObj.Edit(driver);
        }
        [Test]
        public void Delete()
        {
            IWebDriver driver = new ChromeDriver();
            ManageListing MangageListingObj = new ManageListing();
            MangageListingObj.Delete(driver);
        }
        [TearDown]
        public void close()
        {
           

            IWebDriver driver = new ChromeDriver();
            driver.Close();
        }


    }
}