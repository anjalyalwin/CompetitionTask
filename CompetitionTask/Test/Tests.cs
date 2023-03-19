using CompetitionTask.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CompetitionTask.Utilities;
using OpenQA.Selenium.DevTools.V108.Network;


// Open Chrome browser
IWebDriver driver = new ChromeDriver();

        // login page object Intialization and defintion
        LoginPage loginpageObj = new LoginPage();
        loginpageObj.LoginActions(driver);
        //shareskills object intialization and defintion
        Shareskills ShareskillsObj = new Shareskills();
        ShareskillsObj.Gotomanagelisting(driver);
   
      
        //managelisting object Intialization and defition
        ManageListing MangageListingObj = new ManageListing();
        MangageListingObj.Edit(driver);
  
      
       
        MangageListingObj.Delete(driver);
   









