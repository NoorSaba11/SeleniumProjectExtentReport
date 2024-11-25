using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace SeleniumProjectExtentReport
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public  void UnitTest()
        {
            ExtentReports extent = new ExtentReports();

            var htmlReporter = new ExtentSparkReporter("00.html");

            extent.AttachReporter(htmlReporter);

            extent.CreateTest("testcase1").Log(Status.Pass, "Test Case Passed!!");

            extent.Flush();
        }
        
    }
}