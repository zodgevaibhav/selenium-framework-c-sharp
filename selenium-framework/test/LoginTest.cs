using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_framework.common;

class Program : BaseSelenium
    {
    public static void Main(string [] args)
    {
    }

        [Test]
        public void verifyAdminLoginSuccessful()
        {
        LoginPage lp = new LoginPage();
        lp.naviagteToLoginPage();
        }

}