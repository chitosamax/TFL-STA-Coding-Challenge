using STACodingChallenge.PageObject;
using System;
using TechTalk.SpecFlow;

namespace STACodingChallenge.StepDefinition
{
    [Binding]
    public class EditPreferencesSteps
    {
        EditPreferencePage editPreferencePage;
        public EditPreferencesSteps()
        {
            editPreferencePage = new EditPreferencePage();
        }










        [Given(@"that the journey is planned")]
        public void GivenThatTheJourneyIsPlanned()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click on the edit preference button")]
        public void GivenIClickOnTheEditPreferenceButton()
        {
            editPreferencePage.ClickOnEditPreferenceButton();
        }
        
        [Given(@"I select routes with least walking")]
        public void GivenISelectRoutesWithLeastWalking()
        {
            editPreferencePage.ClickOnLeastWalkingButton();
        }
        
        [When(@"I update journey")]
        public void WhenIUpdateJourney()
        {
            editPreferencePage.ClickOnUpdateJourney();
        }
        
        [Then(@"I should be able to validate journey time")]
        public void ThenIShouldBeAbleToValidateJourneyTime()
        {
            editPreferencePage.GetJourneyTime();
        }
    }
}
