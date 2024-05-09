using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Login_POM.BaseTest;

public class baseTest
{
    protected IWebDriver _driver;
    [SetUp]
    public void setup()
    {
        _driver = new ChromeDriver();
        _driver.Navigate().GoToUrl("https://www.facebook.com/login/");
        _driver.Manage().Window.Maximize();
    }
    [TearDown]
    public void close()
    {
        _driver.Dispose();
    }
}