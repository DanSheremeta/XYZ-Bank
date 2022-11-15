using NUnit.Framework;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    public class BaseSteps
    {
        protected static IWebDriver driver;

        [BeforeFeature]
        public static void BeforeFeauture()
        {
            driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Close();
        }
    }
}