using Login_POM.Helper;
using OpenQA.Selenium;

namespace Login_POM.Pages;

public class loginPage
{
    private  IWebDriver driver;
    
    public loginPage(IWebDriver driver)
    {  
        this.driver = driver;
    }

    IWebElement emailElement => driver.FindElement(By.Id("email"));
    IWebElement passwordElement => driver.FindElement(By.Id("pass"));
    IWebElement buttonLogin => driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div[2]/div[2]/form/div/div[3]/button"));
    public void enterEmailElement(string email)
    {
        seleniumCustomMethod.enterText(emailElement,email);
    }
    public void enterPasswordElement(string password)
    {
        seleniumCustomMethod.enterText(passwordElement,password);
    }

    public void clickButtonLogin()
    {
        seleniumCustomMethod.clickElement(buttonLogin);
    }
    public void login(string email, string password)
    {
        seleniumCustomMethod.enterText(emailElement,email);
        seleniumCustomMethod.enterText(passwordElement,password);
        seleniumCustomMethod.clickElement(buttonLogin);
        Thread.Sleep(5000);
       
    }
}