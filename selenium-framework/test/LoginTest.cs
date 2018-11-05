using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_framework.common;

class Program : BaseSelenium
    {
    public static void Main(string [] args)
    {
        IWebDriver dr = new ChromeDriver();
        dr.Navigate().GoToUrl("http://www.google.com");
    }

        [Test]
        public void verifyAdminLoginSuccessful()
        {
        LoginPage lp = new LoginPage();
        lp.naviagteToLoginPage()
            .login("Admin", "admin123")
                .verifyWelcomeText("Welcome Admin");
        }

}