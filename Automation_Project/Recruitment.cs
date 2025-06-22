using OpenQA.Selenium;

namespace Automation_Project
{
    public class Recruitment
    {
        //  XPath for the Recruitment tab
        By recruitmentTab = By.XPath("//*[@id='app']/div[1]/div[1]/aside/nav/div[2]/ul/li[5]/a/span");

        public void OpenRecruitmentPage()
        {
            Driver.driver.FindElement(recruitmentTab).Click();
        }

        public bool IsRecruitmentPageLoaded()
        {
            // Recruitment page URL should includes "/recruitment/viewCandidates"
            return Driver.driver.Url.Contains("/recruitment/viewCandidates");
        }
    }
}
