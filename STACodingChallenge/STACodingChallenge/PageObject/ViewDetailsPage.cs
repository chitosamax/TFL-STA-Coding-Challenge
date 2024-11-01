using OpenQA.Selenium;
using STACodingChallenge.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace STACodingChallenge.PageObject
{
    class ViewDetailsPage
    {
        ViewDetailsPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement viewDetailsButton => driver.FindElement(By.XPath("//button[contains(text(),'View Details')]"));
        IWebElement accessInformation => driver.FindElement(By.XPath("//div[contains(@class, 'station-access-info')]"));







        public void ClickOnViewDetailsButton()
        {
            viewDetailsButton.Click();
        }

        public string GetAccessInformationText()
        {
            return accessInformation.Text;
        }

        public bool IsAccessInformationDisplayedForCoventGarden()
        {
            return accessInformation.Text.Contains("Covent Garden Underground Station");
        }












    }
}
