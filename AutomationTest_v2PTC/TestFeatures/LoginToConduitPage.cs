using NUnit.Framework;
using CoreFrameWork;
using OpenQA.Selenium;
using TestProject.PageObject.Conduit;
using TestProject;

namespace AutomationTest
{
    [TestFixture]
    public class LoginToConduitPage : MasterTest
    {
        [Test]
        public static void UserCanCreateAccountSuccessfully()
        {
            ConduitPage.UserGoToHomePage();
            ConduitPage.UserClicksOnSignUpBtn();
            ConduitPage.UserShouldBeRedirectToSignUpPage();
            ConduitPage.UserFilterUserNameAs("TesshggsssdddtUserX");
            ConduitPage.UserFilterEmailAs("tessssgddst@gmail.com");
            ConduitPage.UserFilterPasswordAs("123456");
            ConduitPage.UserClickOnSignInBtnOnSignInForm();
            ConduitPage.UserShouldBeRedirectedToUserHomePage();
        }

        [Test]
        public static void UserCanNotLogInWhenEnteringAWrongEmailAdress()
        { 
            ConduitPage.UserGoToHomePage();
            ConduitPage.UserClicksOnSignInBtn();
            ConduitPage.UserShouldBeRedirectToSignIpPage();
            ConduitPage.UserFilterEmailAs("tesdst@gmail.com");
            ConduitPage.UserFilterPasswordAs("123456");
            ConduitPage.UserClickOnSignInBtnOnSignInForm();
            ConduitPage.UserShouldGetTheErrorMessage("email or password is invalid");
            ConduitPage.UserTillInSignInPage();

        }


    }
}