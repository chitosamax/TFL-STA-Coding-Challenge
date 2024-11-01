using OpenQA.Selenium;
using STACodingChallenge.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace STACodingChallenge.PageObject
{
    class JourneyPlannerPage
    {
        IWebDriver driver;

        public JourneyPlannerPage(IWebDriver driver)
        {
            driver = Hooks1.driver;
        }


        IWebElement StartLocation => driver.FindElement(By.Id("InputFrom"));
        IWebElement EndLocation => driver.FindElement(By.Id("InputTo"));
        IWebElement PlanJourneyButton => driver.FindElement(By.Id("plan-journey-button"));
        By SuggestionList => By.CssSelector(".suggestions");

        public void Open()
        {
            driver.Navigate().GoToUrl("https://tfl.gov.uk/plan-a-journey");
        }

        public void SelectStartLocationFromSuggestions(string partialText)
        {
            StartLocation.SendKeys(partialText);
            Thread.Sleep(1000);  
            StartLocation.SendKeys(Keys.ArrowDown); 
            StartLocation.SendKeys(Keys.Enter);    
        }

        public void SelectEndLocationFromSuggestions(string partialText)
        {
            EndLocation.SendKeys(partialText);
            Thread.Sleep(1000); 
            EndLocation.SendKeys(Keys.ArrowDown);
            EndLocation.SendKeys(Keys.Enter);
        }

        public void ClickPlanJourney()
        {
            PlanJourneyButton.Click();
        }






    }
}
