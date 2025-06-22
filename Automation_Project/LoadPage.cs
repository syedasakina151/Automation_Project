using System;
using OpenQA.Selenium;

namespace Automation_Project
{
    public class LoadPage
    {
        public void Open()
        {
            Driver.driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            Console.WriteLine("Login page opened.");
            // Implicit wait will handle element loading
        }

        public void Verify()
        {
            string title = Driver.driver.Title;

            if (title.Contains("OrangeHRM"))
            {
                Console.WriteLine("Login page loaded successfully.");
            }
            else
            {
                Console.WriteLine("Login page failed to load.");
            }
        }
    }
}
