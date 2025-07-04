// This test verifies:
// 1. Start the browser
// 2. Login page loads
// 3. Login with invalid username
// 4. Login with invalid password
// 5. Login with valid credentials
// 6. Dashboard is accessible
// 7. Admin tab opens Admin module
// 8. PIM tab opens PIM module
// 9. Recruitment tab opens Recruitment module
// 10. Change Password screen opens
// 11. Positive case of Change Password
// 12–15. Negative Change Password cases
// 16. Claim module is accessible and user can enter in employee field
// 17. Buzz page is accessible
// 18. User can post news feed
// 19. Logout

using System;
using OpenQA.Selenium;

namespace Automation_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test 1: Start the browser
            Driver.Start();

            // Test 2: Login page Load 
            LoadPage page = new LoadPage();
            page.Open();
            page.Verify();

            // Test 3: Login with invalid username
            Login login = new Login();
            login.PerformLogin("Aadmin", "admin123");

            // Test 4: Login with invalid password
            LoadPage page2 = new LoadPage();
            page2.Open();
            login.PerformLogin("Admin", "aaadmin123");

            // Test 5: Login with valid credentials
            LoadPage page3 = new LoadPage();
            page3.Open();
            login.PerformLogin("Admin", "admin123");

            // Test 6: Dashboard is accessible
            if (login.IsDashboardVisible())
                Console.WriteLine("Login successful. Dashboard loaded.");
            else
                Console.WriteLine("Login failed.");

            if (login.IsDashboardVisible())
                Console.WriteLine("Dashboard is accessible after login.");
            else
                Console.WriteLine("Dashboard is NOT accessible after login.");

            // Test 7: Admin tab opens Admin module
            Admin admin = new Admin();
            admin.OpenAdminModule();
            if (admin.IsAdminModuleLoaded())
                Console.WriteLine("Admin module loaded successfully.");
            else
                Console.WriteLine("Failed to load Admin module.");

            // Test 8: PIM tab opens PIM module
            PIM pim = new PIM();
            pim.OpenPIMModule();
            if (pim.IsPIMModuleLoaded())
                Console.WriteLine("PIM module loaded successfully.");
            else
                Console.WriteLine("Failed to load PIM module.");

            // Test 9: Recruitment tab opens Recruitment module
            Recruitment recruitment = new Recruitment();
            recruitment.OpenRecruitmentPage();
            if (recruitment.IsRecruitmentPageLoaded())
                Console.WriteLine("Recruitment page loaded successfully.");
            else
                Console.WriteLine("Failed to load Recruitment page.");

            // Test 10: Change Password screen opens
            ChangePasswordMenu cp = new ChangePasswordMenu();
            cp.OpenChangePasswordScreen();
            if (cp.IsChangePasswordPageOpened())
                Console.WriteLine("Change Password screen opened successfully.");
            else
                Console.WriteLine("Failed to open Change Password screen.");

            // Test 11: Change Password Form (Positive)
            ChangePasswordForm form = new ChangePasswordForm();
            form.Submit("Admin@456", "admin123");
            if (form.Success())
                Console.WriteLine("Password changed successfully.");
            else
                Console.WriteLine("Password change failed.");

            // Test 12–15: Change Password Form (Negative)
            form.Case_Mismatched("Admin@456", "admin123", "Wrong@456");
            form.Case_SameAsCurrent("admin123");
            form.Case_BlankFields();
            form.Case_WrongCurrent("wrongpass", "admin123");

            // Test 16: Open Claim page and click Assign Claim
            Claim claim = new Claim();
            claim.OpenClaimPage();

            if (claim.IsClaimPageLoaded())
                Console.WriteLine("Claim Screen opened successfully.");
            else
                Console.WriteLine("Failed to open claim screen");
            //claim.SelectEmployeeWithHint();

            // Test 17: Verify that Buzz page is accessible
            Buzz buzz = new Buzz();
            buzz.OpenBuzzPage();
            if (buzz.IsBuzzPageLoaded())
                Console.WriteLine("Buzz screen opened successfully.");
            else
                Console.WriteLine("Failed to open Buzz screen.");

            // Test 18: Verify that user can post news feed
            buzz.ClickWhatsOnMind();
            buzz.CreatePost("This is my first post");

            // Test 19: Logout screen opens
            Logout logout = new Logout();
            logout.OpenLogOutScreen();
            if (logout.IsOpenLogOutScreen())
                Console.WriteLine("Logout successful. User is back on login screen.");
            else
                Console.WriteLine("Logout failed. Still on dashboard.");

            Driver.Stop();
            Console.WriteLine("Test complete. Press any key to exit.");
            
        }
    }
}
