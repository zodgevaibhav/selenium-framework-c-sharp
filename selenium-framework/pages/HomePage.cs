using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

class HomePage
{
    [FindsBy(How = How.Id, Using = "welcome")]
    private IWebElement welcomeText;

    private WebDriverWait wt;
    public HomePage()
    {
        TimeSpan timeOut = new TimeSpan(0, 0, 20);  //TimeSpan(int hr, int min, int sec)
        PageFactory.InitElements(WebDriverFactory.getDriver(),this);
        wt = new WebDriverWait(WebDriverFactory.getDriver(),timeOut);
    }

    public HomePage verifyWelcomeText(string expectedWelComeText)
    {
        Assert.AreEqual(expectedWelComeText, welcomeText.Text);
        return this;
    }

    public HomePage isPageLoaded()
    {
        wt.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(welcomeText));
        return this;
    }
}
