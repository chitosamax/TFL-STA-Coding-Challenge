using OpenQA.Selenium;
using STACodingChallenge.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace STACodingChallenge.PageObject
{
    class EditPreferencePage
    {
        public EditPreferencePage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement editPreference => driver.FindElement(By.Id("edit-preferences"));

        IWebElement leastWalkingOption => driver.FindElement(By.Id("LeastWalkingOption"));
            IWebElement updateJourney => driver.FindElement(By.Id("update-journey"));
        IWebElement journeyTime => driver.FindElement(By.CssSelector("journey-duration"));

          










            public void ClickOnEditPreferenceButton()
            {
                editPreference.Click();
            }
        public void ClickOnLeastWalkingButton()
        {
            leastWalkingOption.Click();
        }

        public void ClickOnUpdateJourney()
        {
            updateJourney.Click();
        }

        public string GetJourneyTime()
        {
            return journeyTime.Text;
        }

            








        









    }
}
