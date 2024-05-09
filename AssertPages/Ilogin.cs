namespace Login_POM.AssertPages;

public interface Ilogin
{
    void loginSuccessfullyWithValidData(string expertResult, string actualResult);
    void loginSuccessfullyWithInvalidData(string expertResult, string actualResult);
    void loginSuccessfullyWithEmailBlank(string expertResult, string actualResult);
    void loginSuccessfullyWithPasswordBlank(string expertResult, string actualResult);
}