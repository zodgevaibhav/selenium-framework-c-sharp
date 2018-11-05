using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_framework.common;

class LoginTest : BaseSelenium
{
    private const string currentClassName = "LoginTest"; //It must be constant

    public static void Main(string[] args)
    {
    }

    [Test, TestCaseSource("dataProvider", new object[] { currentClassName, "verifyAdminLoginSuccessful" }),Parallelizable]
    public void verifyAdminLoginSuccessful(string userName, string password)
    {
        LoginPage lp = new LoginPage();
        lp.naviagteToLoginPage()
            .login(userName, password)
                .verifyWelcomeText("Welcome Admin");
    }

    [Test, Parallelizable]
    public void verifyAdminLoginSuccessful1()
    {
        LoginPage lp = new LoginPage();
        lp.naviagteToLoginPage()
            .login("Admin", "admin123")
                .verifyWelcomeText("Welcome Admin");
    }

    [Test, Parallelizable]
    public void verifyAdminLoginSuccessful2()
    {
        LoginPage lp = new LoginPage();
        lp.naviagteToLoginPage()
            .login("Admin", "admin123")
                .verifyWelcomeText("Welcome Admin");
    }
}