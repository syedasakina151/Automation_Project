using OpenQA.Selenium;

namespace Automation_Project
{
    public class Buzz
    {
        //By buzzTab = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[12]/a/span");
        By buzzTab = By.CssSelector("a.oxd-main-menu-item[href*='/buzz/viewBuzz']");
      //By whatsOnMind = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div/div[1]/div[1]/div[2]/form/div/textarea");
        By whatsOnMind = By.CssSelector("textarea[placeholder=\"What's on your mind?\"]");

        // whatsOnMind = By.XPath("//div[contains(@class,'oxd-buzz-post') and contains(@class,'oxd-buzz-post--active')]//textarea[@placeholder=\"What's on your mind?\"]\r\n");
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
