

using SeleniumExtras.PageObjects;

class LoginPage
    {

    public void check()
    {
        PageFactory.InitElements(WebDriverFactory.getDriver(), this);
    }

    public LoginPage naviagteToLoginPage()
    {
        WebDriverFactory.getDriver().Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        return this;
    }
    }
