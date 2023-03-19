using CompetitionTask.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CompetitionTask.stepdefinition
{
    [Binding]
    public class Feature1StepDefinitions
    {
        [Given(@"I logged into local host")]
        public void GivenILoggedIntoLocalHost()
        {
            IWebDriver driver = new ChromeDriver();
            LoginPage loginpageObj = new LoginPage();
            loginpageObj.LoginActions(driver);
        }

        [When(@"I navigate to shareskills page")]
        public void WhenINavigateToShareskillsPage()
        {
            IWebDriver driver = new ChromeDriver();
            Shareskills ShareskillsObj = new Shareskills();
            ShareskillsObj.Gotomanagelisting(driver);


        }

        [When(@"I added skills in shareskills")]
        public void WhenIAddedSkillsInShareskills()
        {
            IWebDriver driver = new ChromeDriver();
            ManageListing MangageListingObj = new ManageListing();
            MangageListingObj.Edit(driver);

        }

        [Then(@"The skills added successfully to manage listings")]
        public void ThenTheSkillsAddedSuccessfullyToManageListings()
        {
            IWebDriver driver = new ChromeDriver();
            ManageListing MangageListingObj = new ManageListing();
            MangageListingObj.Delete(driver);

        }
    }
}
