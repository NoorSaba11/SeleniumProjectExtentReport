using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;



namespace SeleniumProjectExtentReport
{
    [TestClass]
    public class SeleniumC
    {
       // private  ExtentReports extent;
        private static ExtentTest test;

        [ClassInitialize]
        public static void ExtentStart(TestContext context)
        {
            ExtentReports extent = new ExtentReports();
            
            //var htmlReporter = new ExtentHtmlReporter(@"C:\Users\sabahnoo\source\repos\SeleniumProjectExtentReport\SeleniumProjectExtentReport\ExtentReports\SeleniumC.html");
            var htmlReporter = new ExtentHtmlReporter("NoorReportsExtent.html");

            extent.AttachReporter(htmlReporter);
            extent.CreateTest("testcase1");
            extent.Flush();


        }

        [ClassCleanup]
        public static void ExtentClose()
        {
          //  extent.Flush(); // Just flush the existing report
        }

        //[TestMethod]
        //public void Test1()
        //{
        //    IWebDriver driver = null;

        //    try
        //    {
        //        test = extent.CreateTest("Test1").Info("Test Started");
        //       // driver = new ChromeDriver();
        //       // driver.Manage().Window.Maximize();
        //        test.Log(Status.Info, "Chrome Browser launched");
        //       // driver.Url = "https://www.facebook.com/";
        //       // IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
        //       // emailTextField.SendKeys("SeleniumC#");
        //        test.Log(Status.Info, "Email id entered");
        //        test.Log(Status.Pass, "Test1 Passed");
        //    }
        //    catch (Exception ex)
        //    {
        //        test.Log(Status.Fail, $"Test failed with exception: {ex.Message}");
        //        Assert.Fail("Test Aborted: " + ex.Message);
        //    }
        //    finally
        //    {
        //        //driver?.Quit(); // Clean up the driver
        //    }
       // }
    }
}