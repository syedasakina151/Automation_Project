using OpenQA.Selenium;

namespace Automation_Project
{
    public class ChangePasswordForm
    {
        By currentPwd = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/input");
        By newPwd = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[1]/div/div[2]/input");
        By confirmPwd = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[2]/div/div[2]/input");
        By saveBtn = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[3]/button[2]");

        public void Submit(string oldPass, string newPass)
        {
            Driver.driver.FindElement(currentPwd).SendKeys(oldPass);
            Driver.driver.FindElement(newPwd).SendKeys(newPass);
            Driver.driver.FindElement(confirmPwd).SendKeys(newPass);
            Driver.driver.FindElement(saveBtn).Click();
        }

        public bool Success()
        {
            return Driver.driver.PageSource.Contains("Success");
        }

        public void Case_Mismatched(string current, string newPass, string confirm)
        {
            Driver.driver.FindElement(currentPwd).Clear();
            Driver.driver.FindElement(newPwd).Clear();
            Driver.driver.FindElement(confirmPwd).Clear();

            Driver.driver.FindElement(currentPwd).SendKeys(current);
            Driver.driver.FindElement(newPwd).SendKeys(newPass);
            Driver.driver.FindElement(confirmPwd).SendKeys(confirm);
            Driver.driver.FindElement(saveBtn).Click();
        }

        public void Case_SameAsCurrent(string current)
        {
            Driver.driver.FindElement(currentPwd).Clear();
            Driver.driver.FindElement(newPwd).Clear();
            Driver.driver.FindElement(confirmPwd).Clear();

            Driver.driver.FindElement(currentPwd).SendKeys(current);
            Driver.driver.FindElement(newPwd).SendKeys(current);
            Driver.driver.FindElement(confirmPwd).SendKeys(current);
            Driver.driver.FindElement(saveBtn).Click();
        }

        public void Case_BlankFields()
        {
            Driver.driver.FindElement(currentPwd).Clear();
            Driver.driver.FindElement(newPwd).Clear();
            Driver.driver.FindElement(confirmPwd).Clear();
            Driver.driver.FindElement(saveBtn).Click();
        }

        public void Case_WrongCurrent(string wrong, string newPass)
        {
            Driver.driver.FindElement(currentPwd).Clear();
            Driver.driver.FindElement(newPwd).Clear();
            Driver.driver.FindElement(confirmPwd).Clear();

            Driver.driver.FindElement(currentPwd).SendKeys(wrong);
            Driver.driver.FindElement(newPwd).SendKeys(newPass);
            Driver.driver.FindElement(confirmPwd).SendKeys(newPass);
            Driver.driver.FindElement(saveBtn).Click();
        }
    }
}
