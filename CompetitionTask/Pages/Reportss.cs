using AventStack.ExtentReports;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionTask.Pages
{
    [SetUpFixture]
    public abstract class
        ReportsGenerationclass
    {
        protected ExtentReports extent;
        protected ExtentTest test;

        [OneTimeSetUp]

        protected void Setup()
        {
            var path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actualPath = path.Substring(0, path.LastIndexOf("Reportss"));
            var projectPath = new Uri(actualPath).LocalPath;
            Directory.CreateDirectory(projectPath.ToString() + "Reportss");
            var reportPath = projectPath + "Reportss\\ExtentReport.html";
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
           
            
        }
        [OneTimeTearDown]
        protected void TearDown()
        {
            extent.Flush();
        }
        
            
    }
}