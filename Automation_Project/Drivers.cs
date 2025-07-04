using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Automation_Project
{
    public class Driver
    {
        public static IWebDriver driver;

        public static void Start()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddArgument("--incognito");

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();

            // Implicit wait added
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void Stop()
        {
            driver.Quit();
        }
    }
}
