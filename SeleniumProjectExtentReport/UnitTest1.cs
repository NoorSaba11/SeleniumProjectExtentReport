using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using static System.Net.WebRequestMethods;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.IO;
using AventStack.ExtentReports.Model;
using OpenQA.Selenium.BiDi.Modules.Script;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;


namespace SeleniumProjectExtentReport
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public  void UnitTest()
        {
            //get current directory

            var path = Environment.CurrentDirectory;
            //"C:\\Users\\mushtusa\\Source\\Repos\\SeleniumProjectExtentReport\\SeleniumProjectExtentReport\\bin\\Debug\\net8.0"

            var parent = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(path).ToString().ToString()).ToString()).ToString()).ToString();


            ExtentReports extent = new ExtentReports();

            var htmlReporter = new ExtentSparkReporter($"{parent}\\ExtentReport\\00.html");

            extent.AttachReporter(htmlReporter);

            extent.CreateTest("testcase1").Log(Status.Pass, "Test Case Passed!!");

            extent.Flush();
        }
        
    }
}