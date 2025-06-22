using OpenQA.Selenium;

namespace Automation_Project
{
    public class Login
    {
        public void PerformLogin(string username, string password)
        {
            Driver.driver.FindElement(By.Name("username")).SendKeys(username);
            Driver.driver.FindElement(By.Name("password")).SendKeys(password);
            Driver.driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            // Implicit wait will handle dashboard loading
        }

        public bool IsDashboardVisible()
        {
            return Driver.driver.Url.Contains("dashboard");
        }
    }
}
