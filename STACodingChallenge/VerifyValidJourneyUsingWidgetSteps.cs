using System;
using TechTalk.SpecFlow;

namespace STACodingChallenge...
{
    [Binding]
    public class VerifyValidJourneyUsingWidgetSteps
    {
        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter my start off location as ""(.*)""")]
        public void GivenIEnterMyStartOffLocationAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select ""(.*)"" from the drop down")]
        public void GivenISelectFromTheDropDown(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter my final destination as ""(.*)""")]
        public void GivenIEnterMyFinalDestinationAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on plan my journey button")]
        public void WhenIClickOnPlanMyJourneyButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can validate the result for both walking and cycling time")]
        public void ThenICanValidateTheResultForBothWalkingAndCyclingTime()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
