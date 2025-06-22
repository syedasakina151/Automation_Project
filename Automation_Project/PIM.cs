using OpenQA.Selenium;

namespace Automation_Project
{
    public class PIM
    {

        By pimTab = By.XPath("//*[@id='app']/div[1]/div[1]/aside/nav/div[2]/ul/li[2]/a");

        public void OpenPIMModule()
        {
            Driver.driver.FindElement(pimTab).Click();
        }
        public bool IsPIMModuleLoaded()
        {
            // url contains
            return Driver.driver.Url.Contains("/pim/viewEmployeeList");
        }
    }
}
