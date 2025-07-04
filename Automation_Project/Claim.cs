using OpenQA.Selenium;

namespace Automation_Project
{
    public class Claim
    {
        By claimTab = By.XPath("//*[@id='app']/div[1]/div[1]/aside/nav/div[2]/ul/li[11]/a/span");
        // assignClaimBtn = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/div[1]/button");
        By assignClaimBtn = By.XPath("//button[i[contains(@class, 'bi-plus')]] and normalize-space()='Assign Claim']\r\n");
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
