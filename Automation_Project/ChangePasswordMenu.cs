using OpenQA.Selenium;

namespace Automation_Project
{
    public class ChangePasswordMenu
    {
        By profileImage = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[3]/ul/li/span");
        By changePasswordOption = By.XPath("//*[@id='app']/div[1]/div[1]/header/div[1]/div[3]/ul/li/ul/li[3]/a");

        public void OpenChangePasswordScreen()
        {
            Driver.driver.FindElement(profileImage).Click();
            Driver.driver.FindElement(changePasswordOption).Click();
        }

        public bool IsChangePasswordPageOpened()
        {
            return Driver.driver.Url.Contains("/updatePassword");
        }
    }
}
