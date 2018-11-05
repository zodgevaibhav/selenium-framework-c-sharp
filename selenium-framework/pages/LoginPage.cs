

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

class LoginPage
{

    [FindsBy(How = How.Id, Using = "txtUsername")]
    private IWebElement txtUserName;

    [FindsBy(How = How.Id, Using = "txtPassword")]
    private IWebElement txtPassword;

    [FindsBy(How = How.Id, Using = "btnLogin")]
    private IWebElement loginButton;

    public LoginPage()
    {
        PageFactory.InitElements(WebDriverFactory.getDriver(), this);
    }

    public LoginPage naviagteToLoginPage()
    {
        WebDriverFactory.getDriver().Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        return this;
    }

    public HomePage login(string userName, string password)
    {
        txtUserName.SendKeys(userName);
        txtPassword.SendKeys(password);
        loginButton.Click();
        return new HomePage().isPageLoaded();
    }
}
