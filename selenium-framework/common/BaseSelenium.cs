
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

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
    }
}
