using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using STACodingChallenge.PageObject;
using System;
using TechTalk.SpecFlow;

namespace STACodingChallenge.StepDefinition
{
    [Binding]
    public class JourneyPlannerSteps
    {
        IWebDriver driver;
        JourneyPlannerPage journeyPlannerPage;








        [Given(@"I navigate to TFL Journey Planner Page")]
        public void GivenINavigateToTFLJourneyPlannerPage()
        {
            journeyPlannerPage.Open();
        }
        
        [When(@"I select ""(.*)"" from the start location suggestions")]
        public void WhenISelectFromTheStartLocationSuggestions(string p0)
        {
            journeyPlannerPage.SelectStartLocationFromSuggestions(startLocation);
        }
        
        [When(@"I select ""(.*)"" from the end location suggestions")]
        public void WhenISelectFromTheEndLocationSuggestions(string p0)
        {
            journeyPlannerPage.SelectEndLocationFromSuggestions(endLocation);
        }
        
        [When(@"I click the ""(.*)"" button")]
        public void WhenIClickTheButton(string p0)
        {
            journeyPlannerPage.ClickPlanJourney();
        }
        
        [Then(@"I should see the journey options for both walking and cycling")]
        public void ThenIShouldSeeTheJourneyOptionsForBothWalkingAndCycling()
        {
            Assert.IsTrue(driver.PageSource.Contains("Walking"));
            Assert.IsTrue(driver.PageSource.Contains("Cycling"));
        }
        
        [Then(@"I validate that the walking time for the journey is displayed")]
        public void ThenIValidateThatTheWalkingTimeForTheJourneyIsDisplayed()
        {
            var walkingTimeElement = driver.FindElement(By.XPath("//div[contains(text(),'Walking')]/following-sibling::div[contains(@class,'duration')]"));
            Assert.IsTrue(walkingTimeElement.Displayed, "Walking time is not displayed.");
        }
        
        [Then(@"I validate the cycling time is displayed")]
        public void ThenIValidateTheCyclingTimeIsDisplayed()
        {
            var cyclingTimeElement = driver.FindElement(By.XPath("//div[contains(text(),'Cycling')]/following-sibling::div[contains(@class,'duration')]"));
            Assert.IsTrue(cyclingTimeElement.Displayed, "Cycling time is not displayed.");
        }
    }
}
