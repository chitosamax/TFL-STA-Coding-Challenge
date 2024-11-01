using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using STACodingChallenge.PageObject;
using System;
using TechTalk.SpecFlow;

namespace STACodingChallenge.StepDefinition
{
    [Binding]
    public class NullJourneyPlannerSteps
    {
        IWebDriver driver;
        NullJourneyPlannerPage nullJourneyPlannerPage;








        [Given(@"I am on the Journey Planner page bfor TFL")]
        public void GivenIAmOnTheJourneyPlannerPageBforTFL()
        {
            nullJourneyPlannerPage.Open();
        }
        
        [When(@"I leave both location fields empty")]
        public void WhenILeaveBothLocationFieldsEmpty()
        {
            nullJourneyPlannerPage.ClearLocationFields();
        }
        
        [When(@"I attempt to click on the plan the journey button")]
        public void WhenIAttemptToClickOnThePlanTheJourneyButton()
        {
            nullJourneyPlannerPage.ClickPlanJourney();
        }
        
        [Then(@"I should see an error message indicating that locations are required")]
        public void ThenIShouldSeeAnErrorMessageIndicatingThatLocationsAreRequired()
        {
            Assert.IsTrue(nullJourneyPlannerPage.IsErrorMessageDisplayed(), "Error message is not displayed when no locations are entered.");
            Console.WriteLine($"Error Message Displayed: {nullJourneyPlannerPage.GetErrorMessageText()}");
        }
    }
}
