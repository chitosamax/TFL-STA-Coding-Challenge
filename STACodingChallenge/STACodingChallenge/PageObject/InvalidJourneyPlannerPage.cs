using OpenQA.Selenium;
using STACodingChallenge.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace STACodingChallenge.PageObject
{
    class InvalidJourneyPlannerPage
    {
        private readonly IWebDriver driver;
        public InvalidJourneyPlannerPage(IWebDriver driver)
        {
            driver = Hooks1.driver;
        }

        IWebElement StartLocation => driver.FindElement(By.Id("InputFrom"));
        IWebElement EndLocation => driver.FindElement(By.Id("InputTo"));
        IWebElement PlanJourneyButton => driver.FindElement(By.Id("plan-journey-button"));
        IWebElement ErrorMessage => driver.FindElement(By.CssSelector(".journey-error-message")); // Adjust selector based on actual error element

        public void Open()
        {
            driver.Navigate().GoToUrl("https://tfl.gov.uk/plan-a-journey");
        }

        public void EnterInvalidStartLocation(string invalidLocation)
        {
            StartLocation.Clear();
            StartLocation.SendKeys(invalidLocation);
        }

        public void EnterInvalidEndLocation(string invalidLocation)
        {
            EndLocation.Clear();
            EndLocation.SendKeys(invalidLocation);
        }

        public void ClickPlanJourney()
        {
            PlanJourneyButton.Click();
        }

        public bool IsErrorMessageDisplayed()
        {
            return ErrorMessage.Displayed;
        }

        public string GetErrorMessageText()
        {
            return ErrorMessage.Text;
        }





    }
}
