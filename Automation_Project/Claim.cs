using OpenQA.Selenium;

namespace Automation_Project
{
    public class Claim
    {
        By claimTab = By.XPath("//span[text()='Claim']");
        // assignClaimBtn = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/div[1]/button");
        By assignClaimBtn = By.XPath("//button[normalize-space()='Assign Claim' and .//i[contains(@class, 'bi-plus')]]");

        public void OpenClaimPage()
        {
            Driver.driver.FindElement(claimTab).Click();
            Driver.driver.FindElement(assignClaimBtn).Click();
        }

        public bool IsClaimPageLoaded()
        {
            return Driver.driver.Url.Contains("/claim");
        }

        public void SelectEmployeeWithHint()
        {
            // Type 't' in employee search field
            Driver.driver.FindElement(By.XPath("//div[contains(@class,'oxd-autocomplete-wrapper')]//input")).SendKeys("t");
        }
    }
}
