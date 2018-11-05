
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;

namespace selenium_framework.common
{
    class BaseSelenium
    {
        [SetUp]
        public void beforeTest()
        {
            System.Console.WriteLine("*******************Inside the before test");
            WebDriverFactory.setDriver(new ChromeDriver());
        }

        [TearDown]
        public void afterTest()
        {
            System.Console.WriteLine("*******************Inside the after test");
            WebDriverFactory.getDriver().Quit();
        }

        public static object[] dataProvider(string className, string methodName)
        {
             string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
             string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
             string projectPath = new Uri(actualPath).LocalPath+"test\\"+ className+".xlsx";

            return ExcelReader.getExcelDataArray(projectPath, methodName);
        }
    }
}
