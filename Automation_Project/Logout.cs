using OpenQA.Selenium;

namespace Automation_Project
{
    public class Logout
    {
        By profileImage = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[3]/ul/li/span");
        By logOut = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[3]/ul/li/ul/li[4]/a");

        public void OpenLogOutScreen()
        {
            Driver.driver.FindElement(profileImage).Click();
            Driver.driver.FindElement(logOut).Click();
        }

        public bool IsOpenLogOutScreen()
        {
            return Driver.driver.Url.Contains("/auth/login");
        }
    }
}
