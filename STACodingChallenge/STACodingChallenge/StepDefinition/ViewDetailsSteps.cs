using Microsoft.VisualStudio.TestTools.UnitTesting;
using STACodingChallenge.PageObject;
using System;
using TechTalk.SpecFlow;

namespace STACodingChallenge.StepDefinition
{
    [Binding]
    public class ViewDetailsSteps
    {
        ViewDetailsPage viewDetailsPage;
        public ViewDetailsSteps()
        {
            viewDetailsPage = new ViewDetailsPage();

            JourneyPlannerPage journeyPlannerPage;

    }









        [Given(@"that I have planned a journey to Covent Garden Underground Station")]
        public void GivenThatIHavePlannedAJourneyToCoventGardenUndergroundStation()
        {
         //scenario   
        }
        
        [When(@"I click on the view details button")]
        public void WhenIClickOnTheViewDetailsButton()
        {
            viewDetailsPage.ClickOnViewDetailsButton();
        }
        
        [Then(@"I should be able to see complete access information in Covent Garden Underground station")]
        public void ThenIShouldBeAbleToSeeCompleteAccessInformationInCoventGardenUndergroundStation()
        {
            Assert.IsTrue(viewDetailsPage.IsAccessInformationDisplayedForCoventGarden(), "Access information for Covent Garden Underground Station is not displayed.");
            Console.WriteLine($"Access Information: {viewDetailsPage.GetAccessInformationText()}");
        }
    }
}
