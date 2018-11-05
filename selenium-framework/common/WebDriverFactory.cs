using OpenQA.Selenium;
using System;

class WebDriverFactory
    {

    [ThreadStatic]
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