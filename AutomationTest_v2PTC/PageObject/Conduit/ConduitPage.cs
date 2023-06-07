using CoreFrameWork;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.PageObject.Conduit
{
    class ConduitPage
    {
        public static IWebDriver driver = MasterTest.driver;
        public static string url = "https://react-redux.realworld.io";

        public static string signUpBtn = "//a[.='Sign up']";
        public static string signInBtn = "//a[.='Sign in']";
        public static string userNameBox = "//input[@placeholder='Username']";
        public static string emailBox = "//input[@placeholder='Email']";
        public static string passwordBox = "//input[@placeholder='Password']";
        public static string signInBtnOnSignInForm = "//button[.='Sign in']";
        public static string signUpBtnOnSignUpForm = "//button[.='Sign up']";
        public static string signInLabelonSignUpForm = "//h1[.='Sign Up']";
        public static string signInLabelonSignInForm = "//h1[.='Sign In']";
        public static string userPictureInMiddleUserHomePage = "//img[@class='user-pic']";
        public static string erroMess = "//ul[@class='error-messages']";

        internal static void UserShouldBeRedirectToSignIpPage()
        {
            bool isDisplay = SeleniumActions.IsVisible(signInLabelonSignInForm);
            if (!isDisplay) { Assert.Fail(); }
        }

        internal static void UserTillInSignInPage()
        {
            UserShouldBeRedirectToSignIpPage();
        }

        internal static void UserClicksOnSignInBtn()
        {
            SeleniumActions.Click(signInBtn);
        }

        internal static void UserClicksOnSignUpBtn()
        {
            SeleniumActions.Click(signUpBtn);
        }

        internal static void UserShouldGetTheErrorMessage(string expectedErrorMess)
        {
            bool isDisplay = SeleniumActions.IsVisible(erroMess);
            if (!isDisplay) { Assert.Fail(); }
            string err = WaitManagement.WaitForElementToBeVisible(erroMess).Text;
            StringAssert.Contains(expectedErrorMess, err);
        }

        internal static void UserFilterUserNameAs(string userName)
        {
            SeleniumActions.ClearAndTypeText(userNameBox,userName);
        }

        internal static void UserFilterPasswordAs(string passWord)
        {
            SeleniumActions.ClearAndTypeText(passwordBox, passWord);
        }

        internal static void UserShouldBeRedirectedToUserHomePage()
        {
            bool isDisplay = SeleniumActions.IsVisible(userPictureInMiddleUserHomePage);
            if (!isDisplay) { Assert.Fail(); }
        }

        internal static void UserClickOnSignInBtnOnSignInForm()
        {
            SeleniumActions.Click(signInBtnOnSignInForm);
        }

        internal static void UserFilterEmailAs(string email)
        {
            SeleniumActions.ClearAndTypeText(emailBox, email);
        }

        internal static void UserShouldBeRedirectToSignUpPage()
        {
            bool isDisplay = SeleniumActions.IsVisible(signInLabelonSignUpForm);
            if (!isDisplay) { Assert.Fail(); }
        }

        internal static void UserGoToHomePage() {
            driver.Url = "https://react-redux.realworld.io";
        }
    }
}
