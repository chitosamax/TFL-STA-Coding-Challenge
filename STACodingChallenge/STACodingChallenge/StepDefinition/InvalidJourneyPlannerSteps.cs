using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using STACodingChallenge.PageObject;
using System;
using TechTalk.SpecFlow;

namespace STACodingChallenge.StepDefinition
{
    [Binding]
    public class InvalidJourneyPlannerSteps
    {

        IWebDriver driver;
        InvalidJourneyPlannerPage invalidJourneyPlannerPage;





        [Given(@"I am on the TfL Journey Planner page")]
        public void GivenIAmOnTheTfLJourneyPlannerPage()
        {
            invalidJourneyPlannerPage.Open();
        }

        [When(@"I enter an invalid start location")]
        public void WhenIEnterAnInvalidStartLocation()
        {
            invalidJourneyPlannerPage.EnterInvalidStartLocation(invalidStartLocation);
        }
        
        [When(@"I enter an invalid end location")]
        public void WhenIEnterAnInvalidEndLocation()
        {
            invalidJourneyPlannerPage.EnterInvalidEndLocation(invalidEndLocation);
        }
        
        [When(@"I attempt to plan the journey")]
        public void WhenIAttemptToPlanTheJourney()
        {
            invalidJourneyPlannerPage.ClickPlanJourney();
        }
        
        [Then(@"I should see an error message indicating no results")]
        public void ThenIShouldSeeAnErrorMessageIndicatingNoResults()
        {
            Assert.IsTrue(invalidJourneyPlannerPage.IsErrorMessageDisplayed(), "Error message is not displayed for an invalid journey.");
            Console.WriteLine($"Error Message Displayed: {invalidJourneyPlannerPage.GetErrorMessageText()}");
        }
    }
}
