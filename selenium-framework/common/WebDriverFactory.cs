using OpenQA.Selenium;

class WebDriverFactory
    {
    private static IWebDriver driver;

    public static IWebDriver getDriver()
    {
        return driver;  
    }

    public static void setDriver(IWebDriver localDriver)
    {
        driver=localDriver;
    }

}