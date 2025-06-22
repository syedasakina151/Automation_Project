using OpenQA.Selenium;

namespace Automation_Project
{
    public class Claim
    {
        By claimTab = By.XPath("//*[@id='app']/div[1]/div[1]/aside/nav/div[2]/ul/li[11]/a/span");
        By assignClaimBtn = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/div[1]/button");

        public void OpenClaimPage()
        {
            Driver.driver.FindElement(claimTab).Click();
            Driver.driver.FindElement(assignClaimBtn).Click();
        }

        public bool IsClaimPageLoaded()
        {
            return Driver.driver.Url.Contains("/claim/viewAssignClaim");
        }

        public void SelectEmployeeWithHint()
        {
            // Type 't' in employee search field
            Driver.driver.FindElement(By.XPath("//div[contains(@class,'oxd-autocomplete-wrapper')]//input")).SendKeys("t");
        }
    }
}
