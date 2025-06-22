using OpenQA.Selenium;

namespace Automation_Project
{
    public class Admin
    {
        // Using the admin tab

        By adminTab = By.XPath("//*[@id='app']/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a");

        public void OpenAdminModule()
        {
            Driver.driver.FindElement(adminTab).Click();
            // Implicit wait will handle element timing
        }

        public bool IsAdminModuleLoaded()
        {
            // URL check
            return Driver.driver.Url.Contains("/admin/viewSystemUsers");
        }
    }
}
