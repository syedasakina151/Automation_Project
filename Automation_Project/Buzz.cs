using OpenQA.Selenium;

namespace Automation_Project
{
    public class Buzz
    {
        By buzzTab = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[12]/a/span");
        By whatsOnMind = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div/div[1]/div[1]/div[2]/form/div/textarea");
        By postButton = By.CssSelector("button.oxd-button.oxd-button--medium.oxd-button--main");

        public void OpenBuzzPage()
        {
            Driver.driver.FindElement(buzzTab).Click();
            // Implicit wait will handle timing
        }

        public bool IsBuzzPageLoaded()
        {
            return Driver.driver.Url.Contains("/buzz/viewBuzz");
        }

        public void ClickWhatsOnMind()
        {
            Driver.driver.FindElement(whatsOnMind).Click();
        }

        public void CreatePost(string message)
        {
            ClickWhatsOnMind();
            Driver.driver.FindElement(whatsOnMind).SendKeys(message);
            Driver.driver.FindElement(postButton).Click();
        }
    }
}
